using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectores.Model.Entities;
using Proyectores.Model;
using Proyectores.Forms.Busquedas;

namespace Proyectores.Forms.ABM {
    public partial class ReservasForm : Form , IFormPersonas, IFormSalones {

        public decimal? ID_Persona { get; set; }
        private string p_nombre;
        public string P_Nombre {
            get { return p_nombre; }
            set {
                p_nombre = value;
                Persona_TB.Text = P_Apellido + ", " + P_Nombre;
            }
        }
        private string p_apellido;
        public string P_Apellido {
            get { return p_apellido; }
            set {
                p_apellido = value;
                Persona_TB.Text = P_Apellido + ", " + P_Nombre;
            }
        }

        private string N_T_persona;
        public string Nombre_Tipo_Persona {
            get { return N_T_persona; }
            set {
                N_T_persona = value;
                Tipo_TB.Text = value;
            }
        }

        public decimal? ID_Salon { get; set; }
        private string nombre_salon;
        public string Nombre_Salon {
            get { return nombre_salon; }
            set {
                nombre_salon = value;
                Salon_TB.Text = value;
            }
        }

        private bool D_Valid { get; set; }
        private bool H_Valid { get; set; }

        ProyectoresModelEntities _db;
        private ReservasGrilla Grilla { get; set; }
        public List<ReservasEntity> List { get; set; }
        private int _selectedIndex;
        public int SelectedIndex {
            get { return _selectedIndex; }
            set {
                _selectedIndex = value;
                FeedData();
            }
        }
        private int FormMode { get; set; }

        public ReservasForm() {
            InitializeComponent();
        }

        public ReservasForm(ReservasGrilla _grilla) {
            InitializeComponent();
            Grilla = _grilla;
            BT_Primero.Hide();
            BT_Anterior.Hide();
            BT_Proximo.Hide();
            BT_Ultimo.Hide();
            Registro_LB.Hide();
            FormMode = 0;
            Fecha_TB.Text = Grilla.SelectedDate.ToShortDateString();
        }

        public ReservasForm(decimal ID, List<ReservasEntity> _list, ReservasGrilla _grilla) {
            InitializeComponent();
            Grilla = _grilla;
            List = _list;
            SelectedIndex = List.FindIndex(x => x.ID == ID);
            FormMode = 1;
            BT_Cancel.Text = "Cancelar";
        }

        public ReservasForm(decimal ID, List<ReservasEntity> _list) {
            InitializeComponent();
            List = _list;
            SelectedIndex = List.FindIndex(x => x.ID == ID);
            FormMode = 2;
            BT_Save.Hide();
            BT_Cancel.Text = "Cerrar";
        }

        private void FeedData() {
            ID_Persona = List[SelectedIndex].ID_PERSONA;
            Persona_TB.Text = List[SelectedIndex].APE_NOM;
            Nombre_Tipo_Persona = List[SelectedIndex].NOMBRE_TIPO_PERSONA;
            Fecha_TB.Text = List[SelectedIndex].FECHA_RESERVA.ToShortDateString();
            D_MTB.Text = List[SelectedIndex].H_DESDEsrt;
            H_MTB.Text = List[SelectedIndex].H_HASTAsrt;
            ID_Salon = List[SelectedIndex].ID_SALON;
            Salon_TB.Text = List[SelectedIndex].NOMBRE_SALON;

            Registro_LB.Text = "Registro " + (SelectedIndex + 1) + " de " + List.Count + ".";
        }

        private void BT_Save_Click(object sender, EventArgs e) {
            //Validaciones

            if (ID_Persona == null || ID_Persona == 0) { MessageBox.Show("Seleccione una persona valida."); return; }

            D_MTB.Focus();
            H_MTB.Focus();
            BT_Save.Focus();

            if (!D_Valid) { MessageBox.Show("Hora Invalida."); D_MTB.Focus(); return; }
            if (!H_Valid) { MessageBox.Show("Hora Invalida."); H_MTB.Focus(); return; }
            if (ID_Salon == null || ID_Salon == 0) { MessageBox.Show("Seleccione un salon valido."); return; }

            string response = "";

            switch (FormMode) {
                case 0: response = DB_Create();
                    break;
                case 1: response = DB_Update();
                    break;
            }


            if (response != "") {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                MessageBox.Show("Se Ha Guardado Correctamente.");
                Grilla.GetData();
                this.BT_Cancel_Click(sender, e);
            }
        }

        private string DB_Create() {
            string response = "";
            _db = new ProyectoresModelEntities();

            Reserva Entity = new Reserva();

            try {
                Entity.ID_PERSONA = (decimal)ID_Persona;
                Entity.ID_SALON = (decimal)ID_Salon;
                Entity.FECHA_RESERVA = Grilla.SelectedDate.Date;
                Entity.FECHA_ALTA = DateTime.Today;
                Entity.H_DESDE = Convert.ToDateTime(D_MTB.Text);
                Entity.H_HASTA = Convert.ToDateTime(H_MTB.Text);

                _db.Reserva.Add(Entity);
                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error al escribir en la Base de Datos.";
                throw;
            }

            return response;
        }

        private string DB_Update() {
            string response = "";
            _db = new ProyectoresModelEntities();

            decimal id = List[SelectedIndex].ID;

            try {
                Reserva Entity = _db.Reserva.Where(x => x.ID == id).FirstOrDefault();

                Entity.ID_PERSONA = (decimal)ID_Persona;
                Entity.ID_SALON = (decimal)ID_Salon;
                Entity.FECHA_RESERVA = Grilla.SelectedDate.Date;
                Entity.H_DESDE = Convert.ToDateTime(D_MTB.Text);
                Entity.H_HASTA = Convert.ToDateTime(H_MTB.Text);

                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error al escribir en la Base de Datos.";
                throw;
            }

            return response;
        }

        private void OnSearchDbClick(object sender, EventArgs e) {
            switch (((TextBox)sender).Name) {
                case "Persona_TB": {
                        PersonasBusqueda form = new PersonasBusqueda(this);
                        form.ShowDialog();
                        break;
                    }
                case "Salon_TB": {
                        SalonesBusqueda form = new SalonesBusqueda(this);
                        form.ShowDialog();
                        break;
                    }
                default:
                    break;
            }
        }

        private void OnSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter || e.KeyCode != Keys.Return) {
                e.SuppressKeyPress = true;
                return;
            }


            switch (((TextBox)sender).Name) {
                case "Persona_TB": {
                        PersonasBusqueda form = new PersonasBusqueda(this);
                        form.Location = new Point(this.Location.X + (this.Width / 2) - (form.Width / 2), this.Location.Y + (this.Height / 2) - (form.Height / 2));
                        form.ShowDialog();
                        break;
                    }
                case "Salon_TB": {
                        SalonesBusqueda form = new SalonesBusqueda(this);
                        form.Location = new Point(this.Location.X + (this.Width / 2) - (form.Width / 2), this.Location.Y + (this.Height / 2) - (form.Height / 2));
                        form.Focus();
                        form.ShowDialog();
                        break;
                    }
                default:
                    break;
            }

        }

        private void OnSearch_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Back)
                return;

            switch (((TextBox)sender).Name) {
                case "Persona_TB": {
                        this.ID_Persona = null;
                        this.P_Nombre = "";
                        this.P_Apellido = "";
                        break;
                    }
                case "Salon_TB": {
                        this.ID_Salon = null;
                        this.Nombre_Salon = "";
                        break;
                    }
                default:
                    break;
            }
            ((TextBox)sender).Text = "";
        }

        private void D_MTB_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {
            switch (((MaskedTextBox)sender).Name) {
                case "D_MTB":
                    if (e.IsValidInput) D_Valid = true;
                    else D_Valid = false;
                    break;
                case "H_MTB":
                    if (e.IsValidInput) H_Valid = true;
                    else H_Valid = false;
                    break;
                default:
                    break;
            }
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
    }
}
