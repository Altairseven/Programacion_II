using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectores.Classes;
using Proyectores.Model;
using Proyectores.Model.Entities;

namespace Proyectores.Forms.ABM {
    public partial class ProyectoresForm : Form {

        #region Variables Y Propiedades

        public ProyectoresGrilla Grilla { get; set; }
        public List<ProyectoresEntity> List { get; set; }
        public bool EditMode { get; set; }

        private int _selectedIndex;
        public int SelectedIndex {
            get { return _selectedIndex; }
            set {
                _selectedIndex = value;
                FeedData();
            }
        }

        ProyectoresModelEntities _db = new ProyectoresModelEntities();
        #endregion

        #region Constructores

        public ProyectoresForm() {
            InitializeComponent();
            SetupComboboxes();
        }

        public ProyectoresForm(ProyectoresGrilla grilla) {
            InitializeComponent();
            SetupComboboxes();
            Grilla = grilla;
            BT_Primero.Hide();
            BT_Anterior.Hide();
            BT_Proximo.Hide();
            BT_Ultimo.Hide();
        }

        public ProyectoresForm(ProyectoresGrilla grilla, Decimal id, List<ProyectoresEntity> listita) {
            InitializeComponent();
            SetupComboboxes();
            Grilla = grilla;
            List = listita;
            SelectedIndex = List.FindIndex(x => x.ID == id);
            EditMode = true;

        }

        #endregion

        #region Metodos

        private void SetupComboboxes() {
            Db_ComboItem c1i1 = new Db_ComboItem(0, "No");
            Db_ComboItem c1i2 = new Db_ComboItem(1, "Si");
            Db_ComboItem c1i3 = new Db_ComboItem(0, "No");
            Db_ComboItem c1i4 = new Db_ComboItem(1, "Si");
            Db_ComboItem c3i5 = new Db_ComboItem(0, "Descompuesto");
            Db_ComboItem c3i6 = new Db_ComboItem(1, "Funcional");
            List<Db_ComboItem> list1 = new List<Db_ComboItem>();
            List<Db_ComboItem> list2 = new List<Db_ComboItem>();
            List<Db_ComboItem> list3 = new List<Db_ComboItem>();
            list1.Add(c1i1);
            list1.Add(c1i2);
            list2.Add(c1i3);
            list2.Add(c1i4);
            list3.Add(c3i5);
            list3.Add(c3i6);
            comboBox1.DataSource = list1;
            comboBox2.DataSource = list2;
            comboBox3.DataSource = list3;
        }

        private void FeedData() {
            Marca_TB.Text = List[SelectedIndex].MARCA;
            Modelo_TB.Text = List[SelectedIndex].MODELO;
            Nserie_TB.Text = List[SelectedIndex].SERIAL;
            comboBox1.SelectedValue = List[SelectedIndex].HDMI;
            comboBox2.SelectedValue = List[SelectedIndex].DISPONIBLE;
            comboBox3.SelectedValue = List[SelectedIndex].OPERATIVO;
            Registro_LB.Text = "Registro " + (SelectedIndex + 1) + " de " + List.Count + ".";
        }

        private string DB_Create() {
            string response = "";

            Model.Proyectores Entity = new Model.Proyectores();

            Entity.MARCA = Marca_TB.Text;
            Entity.MODELO = Modelo_TB.Text;
            Entity.SERIAL = Nserie_TB.Text;
            Entity.HDMI = (decimal)comboBox1.SelectedValue;
            Entity.DISPONIBLE = (decimal)comboBox2.SelectedValue;
            Entity.OPERATIVO = (decimal)comboBox3.SelectedValue;

            try {
                _db.Proyectores.Add(Entity);
                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error inesperado.";
                throw;
            }

            return response;
        }

        private string DB_Update() {
            string response = "";
            decimal id = List[SelectedIndex].ID;
            Model.Proyectores Entity = _db.Proyectores.Where(x => x.ID == id).FirstOrDefault();

            Entity.MARCA = Marca_TB.Text;
            Entity.MODELO = Modelo_TB.Text;
            Entity.SERIAL = Nserie_TB.Text;
            Entity.HDMI = (decimal)comboBox1.SelectedValue;
            Entity.DISPONIBLE = (decimal)comboBox2.SelectedValue;
            Entity.OPERATIVO = (decimal)comboBox3.SelectedValue;

            try {
                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error inesperado.";
                throw;
            }

            return response;
        }

        private void EnableNavAll() {
            BT_Primero.Enabled = true;
            BT_Anterior.Enabled = true;
            BT_Proximo.Enabled = true;
            BT_Ultimo.Enabled = true;
        }

        #endregion

        #region Eventos
        private void ProyectoresForm_Load(object sender, EventArgs e) {
            if (SelectedIndex == 0) {
                BT_Primero.Enabled = false;
                BT_Anterior.Enabled = false;
            }
            else if (SelectedIndex == List.Count - 1) {
                BT_Proximo.Enabled = false;
                BT_Ultimo.Enabled = false;
            }

        }

        private void BT_Cancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Dispose();
        }
        private void BT_Save_Click(object sender, EventArgs e) {
            //vLIDACIONES
            if (Marca_TB.Text == "") {
                MessageBox.Show("La marca es obligatoria.");
                return;
            }
            if (Modelo_TB.Text == "") {
                MessageBox.Show("El Modelo es obligatorio.");
                return;
            }
            if (Nserie_TB.Text == "") {
                MessageBox.Show("El Numero de serie es obligatorio.");
                return;
            }

            string response = "";

            if (!EditMode)
                response = DB_Create();
            else
                response = DB_Update();

            if (response != "")
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                MessageBox.Show("Se Ha Guardado Correctamente", "", MessageBoxButtons.OK);
                Grilla.GetData();
                BT_Cancel_Click(sender, e);
            }
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
            if (SelectedIndex >= List.Count - 1)
                return;
            SelectedIndex += 1;
            if (SelectedIndex >= List.Count - 1) {
                BT_Proximo.Enabled = false;
                BT_Ultimo.Enabled = false;
            }
        }

        private void BT_Ultimo_Click(object sender, EventArgs e) {
            EnableNavAll();
            SelectedIndex = List.Count - 1;
            BT_Proximo.Enabled = false;
            BT_Ultimo.Enabled = false;
        }





        #endregion

    }
}
