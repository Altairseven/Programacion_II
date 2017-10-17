using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectores.Model;
using Proyectores.Model.Entities;

namespace Proyectores.Forms.ABM {
    public partial class LocalidadForm : Form {

        ProyectoresModelEntities _db = new ProyectoresModelEntities();
        private List<LocalidadesEntity> List;
        private LocalidadGrilla Grid;

        public decimal SelectedID { get; set; }
        private int _selectedIndex;

        public int SelectedIndex {
            get { return _selectedIndex; }
            set {
                _selectedIndex = value;
                SelectedID = List[value].ID;
                FeedData();
            }
        }

        private bool EditMode { get; set; }

        public LocalidadForm() {
            InitializeComponent();
            this.TopLevel = false;
        }

        public LocalidadForm(LocalidadGrilla grid) {
            InitializeComponent();
            this.TopLevel = false;
            Grid = grid;
            
            BT_Primero.Hide();
            BT_Anterior.Hide();
            BT_Proximo.Hide();
            BT_Ultimo.Hide();
            
        }

        public LocalidadForm(decimal ID, List<LocalidadesEntity> _list, LocalidadGrilla grid) {
            InitializeComponent();
            this.TopLevel = false;
            Grid = grid;
            List = _list;
            SelectedIndex = List.FindIndex(x => x.ID == ID);
            EditMode = true;
            
            
        }

        private void LocalidadForm_Load(object sender, EventArgs e) {
            SetupComboBoxes();
        }

        private void SetupComboBoxes() {
            CB_Provincia.DataSource = _db.Provincias.ToList();
            if (!EditMode) //en Modo Agregar, deja vacio el elemento seleccionado del combobox
                CB_Provincia.SelectedValue = "";
        }

        private void FeedData() {
            
            LocalidadesEntity Entity = List[SelectedIndex];

            mTextBox_Edit1.Text = Entity.COD_POSTAL.ToString();
            mTextBox_Edit2.Text = Entity.NOMBRE.ToString();
            CB_Provincia.SelectedValue = Entity.ID_PROVINCIA;

        }

        private void BT_Save_Click(object sender, EventArgs e) {

            //Validaciones:
            decimal cp;
            if (!decimal.TryParse(mTextBox_Edit1.Text, out cp)) {
                MessageBox.Show("El Codigo Postal debe ser numerico.");
                return;
            }
            if (CB_Provincia.SelectedIndex == -1) {
                MessageBox.Show("Seleccione una provincia.");
                return;
            }


            string response = "";

            if (EditMode == true)
               response = DB_Update();
            else
               response = DB_Create();
            
            if (response != "") 
                MessageBox.Show(response);
            else {
                Grid.GetData();
                BT_Cancel_Click(sender, e);
            }

            

        }

        private string DB_Update() {
            string response = "";
            try {
                Localidades Entity = _db.Localidades.Where(x => x.ID == SelectedID).FirstOrDefault();

                Entity.COD_POSTAL = Convert.ToDecimal(mTextBox_Edit1.Text);
                Entity.NOMBRE = mTextBox_Edit2.Text;
                Entity.ID_PROVINCIA = CB_Provincia.SelectedIndex;

                _db.SaveChanges();

            }
            catch (Exception) {
                response = "Se ha producido un error inesperado al actualizar!";
                //throw;
            }

            return response;
        }

        private string DB_Create() {
            string response = "";
            try {
                Localidades Entity = new Localidades();

                Entity.COD_POSTAL = Convert.ToDecimal(mTextBox_Edit1.Text);
                Entity.NOMBRE = mTextBox_Edit2.Text;
                Entity.ID_PROVINCIA = CB_Provincia.SelectedIndex;

                _db.Set<Localidades>().Add(Entity);

                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error inesperado al guardar!";
                throw;
            }
            return response;
        }

        private void BT_Cancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Dispose();
        }

        private void BT_Primero_Click(object sender, EventArgs e) {
            EnableNavAll();
            SelectedIndex = 0;
            BT_Primero.Enabled = false;
            BT_Anterior.Enabled = false;
        }

        private void BT_Anterior_Click(object sender, EventArgs e) {
            EnableNavAll();
            if (SelectedIndex <= 0)
                return;
            SelectedIndex -= 1;
            if (SelectedIndex <= 0) {
                BT_Anterior.Enabled = false;
                BT_Primero.Enabled = false;
            }
        }

        private void BT_Proximo_Click(object sender, EventArgs e) {
            EnableNavAll();
            if (SelectedIndex >= List.Count -1)
                return;
            SelectedIndex += 1;
            if (SelectedIndex >= List.Count - 1) { 
                BT_Proximo.Enabled = false;
                BT_Ultimo.Enabled = true;
            }
        }

        private void BT_Ultimo_Click(object sender, EventArgs e) {
            EnableNavAll();
            SelectedIndex = List.Count - 1;
            BT_Proximo.Enabled = false;
            BT_Ultimo.Enabled = false;
        }

        private void EnableNavAll() {
            BT_Primero.Enabled = true;
            BT_Anterior.Enabled = true;
            BT_Proximo.Enabled = true;
            BT_Ultimo.Enabled = true;
        }

        private void CB_Provincia_Enter(object sender, EventArgs e) {
            CB_Provincia.DroppedDown = true;
        }
    }
}
