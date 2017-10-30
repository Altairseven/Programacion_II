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

namespace Proyectores.Forms.ABM {
    public partial class ReservasGrilla : Form, IGrilla {
        public ReservasGrilla() {
            InitializeComponent();
            Calendar.SelectedDates = new DateTime[1] { DateTime.Today }; 
            SelectedDate = DateTime.Today;
        }

        private DateTime _SelectedDate;
        public DateTime SelectedDate {
            get { return _SelectedDate; }
            set {
                _SelectedDate = value;
                Date_LB.Text = "";
                if (value.Date == DateTime.Today.Date)
                    Date_LB.Text += "(Hoy) - ";
                Date_LB.Text += value.ToShortDateString();

                GetData();
            }
        }
        ProyectoresModelEntities _db;
        public List<ReservasEntity> List { get; set; }


        private void ReservasGrilla_Load(object sender, EventArgs e) {

        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e) {
            SelectedDate = e.Start;
        }

        public void GetData () {
            _getData();
        }

        private void OpenForm(int Mode) {

            ReservasForm form;
            

            switch (Mode) {
                case 0:
                    form = new ReservasForm(this);

                    break;
                case 1:
                    decimal id = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
                    if (dataGridView1.SelectedRows.Count == 0) {
                        MessageBox.Show("Seleccione un elemento.");
                        return;
                    }
                    form = new ReservasForm(id, List, this);
                    break;
                case 2:
                    decimal id1 = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
                    if (dataGridView1.SelectedRows.Count == 0) {
                        MessageBox.Show("Seleccione un elemento.");
                        return;
                    }
                    form = new ReservasForm(id1, List);
                    break;
                default:
                    form = new ReservasForm();
                    break;
            }
            form.TopLevel = false;
            ParentForm.Controls.Add(form);
            form.Location = new Point((this.Location.X + (this.Width / 2)) - (form.Width / 2), (this.Height / 2) - (form.Height / 2));
            form.TopMost = true;
            form.BringToFront();
            form.Show();
            form.Focus();
        }

        private void _getData(decimal showDadosBaja = 0) {
            _db = new ProyectoresModelEntities();
            List = new List<ReservasEntity>();

            try {
                var Q = (from a in _db.Reserva
                         join b in _db.Personas on a.ID_PERSONA equals b.ID
                         join c in _db.Tipos_Persona on b.ID_TIPO_PERSONA equals c.ID
                         join d in _db.Salones on a.ID_SALON equals d.ID
                         where a.FECHA_RESERVA.Equals(SelectedDate.Date)
                         && (showDadosBaja == 1 || (a.ID_MOTIVO_BAJA.Equals(null) && a.FECHA_BAJA.Equals(null)))
                         orderby a.H_DESDE.Hour, a.H_DESDE.Minute ascending
                         select new {
                             a,
                             APE_NOM = b.APELLIDO + ", " + b.NOMBRE,
                             NOMBRE_TIPO_PERSONA = c.NOMBRE,
                             NOMBRE_SALON = d.NOMBRE
                         }).ToList();

                foreach (var item in Q) {
                    ReservasEntity Entity = new ReservasEntity(item.a);
                    Entity.APE_NOM = item.APE_NOM;
                    Entity.NOMBRE_TIPO_PERSONA = item.NOMBRE_TIPO_PERSONA;
                    Entity.NOMBRE_SALON = item.NOMBRE_SALON;
                    List.Add(Entity);
                }
            }
            catch (Exception) {

                throw;
            }
            dataGridView1.DataSource = List;
            
                Registros_LB.Text = "Mostrando " + List.Count.ToString() + " Registro";
            if (List.Count == 1)
                Registros_LB.Text += ".";
            else 
                Registros_LB.Text += "s.";
        }

        private void Calendar_SelectionChanged(object sender, EventArgs e) {
            SelectedDate = Calendar.Value;
        }



        private void AgregarBT_Click(object sender, EventArgs e) {
            OpenForm(0);
        }

        private void button1_Click(object sender, EventArgs e) {
            OpenForm(2);
        }

        private void EditBT_Click(object sender, EventArgs e) {
            OpenForm(1);
        }

        private void DelBT_Click(object sender, EventArgs e) {

        }
    }
}
