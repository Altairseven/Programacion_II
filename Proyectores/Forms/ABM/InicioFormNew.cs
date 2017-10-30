using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectores.Forms.Busquedas;
using Proyectores.Model;

namespace Proyectores.Forms.ABM {
    public partial class InicioFormNew : Form, IFormPersonas, IFormSalones {
        public InicioFormNew() {
            InitializeComponent();
        }



        ProyectoresModelEntities _db;
        private InicioGrilla Grilla { get; set; }

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

        public InicioFormNew(InicioGrilla _grilla) {
            InitializeComponent();
            Grilla = _grilla;

        }
        private void PrestamosAlta_Load(object sender, EventArgs e) {
            _db = new ProyectoresModelEntities();
            P_CB.DataSource = _db.Proyectores.Where(x=> x.DISPONIBLE == 1).ToList();
        }

        private void BT_Save_Click(object sender, EventArgs e) {
            //Validaciones

            if (ID_Persona == null || ID_Persona == 0) { MessageBox.Show("Seleccione una persona valida."); return; }

            if (!D_Valid) { MessageBox.Show("Hora Invalida."); D_MTB.Focus(); return; }
            if (!H_Valid) { MessageBox.Show("Hora Invalida."); H_MTB.Focus(); return; }
            if (ID_Salon == null || ID_Salon == 0) { MessageBox.Show("Seleccione un salon valido."); return; }

            string response = DB_Create();
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
            Prestamos Entity = new Prestamos();

            Entity.ID_PERSONA = (decimal)ID_Persona;
            Entity.ID_SALON = (decimal)ID_Salon;
            Entity.ID_PROYECTOR = (decimal)P_CB.SelectedValue;
            Entity.H_DESDE = Convert.ToDateTime(D_MTB.Text);
            Entity.H_HASTA = Convert.ToDateTime(H_MTB.Text);
            Entity.FECHA = (DateTime)DateTime.Now.Date;
            Entity.ACTIVO = 1;
            //seteo el Proyector como no Disponible
            _db.Proyectores.Where(x => x.ID == Entity.ID_PROYECTOR).FirstOrDefault().DISPONIBLE = 0;

            try {
                _db.Prestamos.Add(Entity);
                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Ha ocurrido un Error";
                throw;
            }
            return response;
        }


        private void BT_Cancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Dispose();
            
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

        private void CB_Enter(object sender, EventArgs e) {
            ((ComboBox)sender).DroppedDown = true;
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e) {

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
    }
}
