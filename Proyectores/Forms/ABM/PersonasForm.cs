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

namespace Proyectores.Forms.ABM
{
    public partial class PersonasForm : Form, Busquedas.IFormLocalidades {
        private decimal? loc_id;
        public decimal? Loc_ID {
            get {

                return loc_id;
            }
            set {
                loc_id = value;

            }
        }
        private decimal? cod_postal;
        public decimal? COD_Postal {
            get {

                return cod_postal;
            }
            set {
                cod_postal = value;
                Cod_Postal_TB.Text = value.ToString();
            }
        }
        private string loc_nombre;
        public String Loc_Nombre {
            get {

                return loc_nombre;
            }
            set {
                loc_nombre = value;
                Localidad_TB.Text = value;
            }
        }

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


        public bool EditMode { get; set; }
        public PersonasGrilla Grilla { get; set; }
        public List<PersonasEntity> List { get; set; }

        public PersonasForm() {
            InitializeComponent();
            this.TopLevel = false;
        }

        public PersonasForm(PersonasGrilla _grilla) {
            InitializeComponent();
            this.TopLevel = false;
            Grilla = _grilla;
            BT_Primero.Hide();
            BT_Anterior.Hide();
            BT_Proximo.Hide();
            BT_Ultimo.Hide();
        }

        public PersonasForm(decimal ID, List<PersonasEntity> _list, PersonasGrilla grid) {
            InitializeComponent();
            this.TopLevel = false;
            Grilla = grid;
            List = _list;
            SelectedIndex = List.FindIndex(x => x.ID == ID);
            EditMode = true;


        }

        ProyectoresModelEntities _db = new ProyectoresModelEntities();

        private void PersonasForm_Load(object sender, EventArgs e) {
            InitComboBoxes();
            if (SelectedIndex == 0) {
                BT_Primero.Enabled = false;
                BT_Anterior.Enabled = false;
            }
            else if (SelectedIndex == List.Count - 1) {
                BT_Proximo.Enabled = false;
                BT_Ultimo.Enabled = false;
            }
        }
        private void InitComboBoxes() {
            TipoDoc_CB.DataSource = _db.Tipo_Documento.ToList();
            Tipo_persona_CB.DataSource = _db.Tipos_Persona.OrderBy(x => x.NOMBRE).ToList();
        }

        private void FeedData() {
            Nombre_TB.Text = List[SelectedIndex].NOMBRE;
            Apellido_TB.Text = List[SelectedIndex].APELLIDO;
            TipoDoc_CB.SelectedValue = List[SelectedIndex].ID_TIPO_DOCUMENTO;
            Documento_TB.Text = List[SelectedIndex].DOCUMENTO.ToString();
            cuit_TB.Text = List[SelectedIndex].CUIT.ToString();
            Tipo_persona_CB.SelectedValue = List[SelectedIndex].ID_TIPO_PERSONA;
            legajo_TB.Text = List[SelectedIndex].LEGAJO;
            Direccion_TB.Text = List[SelectedIndex].DIRECCION;
            Loc_ID = List[SelectedIndex].ID_LOCALIDAD;
            Localidades e = _db.Localidades.Where(x => x.ID == Loc_ID).SingleOrDefault();
            Cod_Postal_TB.Text = e.COD_POSTAL.ToString();
            Localidad_TB.Text = e.NOMBRE;
            email_TB.Text = List[SelectedIndex].EMAIL;
            telefono_TB.Text = List[SelectedIndex].TELEFONO;

            Registro_LB.Text = "Registro " + (SelectedIndex + 1) + " de " + List.Count + ".";
        }

        private void BT_Save_Click(object sender, EventArgs e) {
            //Validaciones:

            if (Nombre_TB.Text == "") { MessageBox.Show("El Campo Nombre, no puede estar vacio."); return; }
            if (Apellido_TB.Text == "") { MessageBox.Show("El Campo Apellido, no puede estar vacio."); return; }


            if (Tipo_persona_CB.Text == "") { MessageBox.Show("El Tipo de persona no es valido."); return; }
            if (Cod_Postal_TB.Text == "" || Loc_ID == null || Loc_ID == 0) { MessageBox.Show("La localidad ingresada no es valida."); return; }
            if (Direccion_TB.Text == "") { MessageBox.Show("La Direccion no puede estar vacia."); return; }
            decimal a = 0;
            if (TipoDoc_CB.Text == "") { MessageBox.Show("El Tipo de documento no es valido."); return; }
            if (Documento_TB.Text == "" && !decimal.TryParse(TipoDoc_CB.Text, out a)) { MessageBox.Show("El Nro de documento no es valido."); return; }
            if (!decimal.TryParse(cuit_TB.Text, out a)) { MessageBox.Show("El CUIT, debe ser numerico"); return; }


            string response;

            if (EditMode)
                response = DB_Update();
            else
                response = DB_Create();

            if (response != "") {
                MessageBox.Show(response);
                return;
            }
            else {
                MessageBox.Show("Se ha guardado correctamente.");
                this.Hide();
                Grilla.GetData();
                this.Dispose();
            }



        }

        private string DB_Create() {
            string response = "";



            try {
                Personas Entity = new Personas();

                Entity.NOMBRE = Nombre_TB.Text;
                Entity.APELLIDO = Apellido_TB.Text;
                Entity.ID_TIPO_DOCUMENTO = Convert.ToDecimal(TipoDoc_CB.SelectedValue);
                Entity.DOCUMENTO = Convert.ToDecimal(Documento_TB.Text);
                Entity.ID_TIPO_PERSONA = Convert.ToDecimal(Tipo_persona_CB.SelectedValue);
                Entity.ID_LOCALIDAD = (decimal)Loc_ID;
                Entity.CUIT = Convert.ToDecimal(cuit_TB.Text);
                Entity.LEGAJO = legajo_TB.Text;
                Entity.DIRECCION = Direccion_TB.Text;
                Entity.TELEFONO = telefono_TB.Text;
                Entity.EMAIL = email_TB.Text;

                _db.Personas.Add(Entity);

                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error al escribir en la Base de Datos.";
                //throw;
            }

            return response;
        }
        private string DB_Update() {
            string response = "";

            decimal id = List[SelectedIndex].ID;

            Personas Entity = _db.Personas.Where(x => x.ID == id).FirstOrDefault();

            try {
                Entity.NOMBRE = Nombre_TB.Text;
                Entity.APELLIDO = Apellido_TB.Text;
                Entity.ID_TIPO_DOCUMENTO = Convert.ToDecimal(TipoDoc_CB.SelectedValue);
                Entity.DOCUMENTO = Convert.ToDecimal(Documento_TB.Text);
                Entity.ID_TIPO_PERSONA = Convert.ToDecimal(Tipo_persona_CB.SelectedValue);
                Entity.ID_LOCALIDAD = (decimal)Loc_ID;
                Entity.CUIT = Convert.ToDecimal(cuit_TB.Text);
                Entity.LEGAJO = legajo_TB.Text;
                Entity.DIRECCION = Direccion_TB.Text;
                Entity.TELEFONO = telefono_TB.Text;
                Entity.EMAIL = email_TB.Text;

                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error al escribir en la Base de Datos.";
                //throw;
            }



            return response;



        }










































        #region eventos
        private void CodPostal_DbCLick(object sender, EventArgs e) {
            Busquedas.LocalidadesBusqueda sform = new Busquedas.LocalidadesBusqueda(this);
            sform.ShowDialog();
        }

        private void Cod_Postal_TB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                Busquedas.LocalidadesBusqueda sform = new Busquedas.LocalidadesBusqueda(this);
                sform.ShowDialog();
            }
            

        }

        private void Cod_Postal_TB_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void Cod_Postal_TB_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Back && Cod_Postal_TB.Text == "")
            {
                Localidad_TB.Text = "";
                Loc_ID = null;
                COD_Postal = null;
                Loc_Nombre = "";
            }
        }

        private void Body_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Nombre_TB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        #endregion

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

        private void EnableNavAll() {
            BT_Primero.Enabled = true;
            BT_Anterior.Enabled = true;
            BT_Proximo.Enabled = true;
            BT_Ultimo.Enabled = true;
        }

        private void BT_Cancel_Click(object sender, EventArgs e) {
            this.Hide();
            Grilla.GetData();
            this.Dispose();
        }
    }
}
