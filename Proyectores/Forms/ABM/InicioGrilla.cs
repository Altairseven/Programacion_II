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
    public partial class InicioGrilla : Form, IGrilla {
        public InicioGrilla() {
            InitializeComponent();
        }

        ProyectoresModelEntities _db;
        List<PrestamosEntity> List;

        private void InicioGrilla_Load(object sender, EventArgs e) {
            GetData();
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker1_ValueChanged(sender, e);
        }

        public void GetData() {
            _db = new ProyectoresModelEntities();

            List = new List<PrestamosEntity>();

            var P = from a in _db.Prestamos
                    join b in _db.Personas on a.ID_PERSONA equals b.ID
                    join c in _db.Tipos_Persona on b.ID_TIPO_PERSONA equals c.ID
                    join d in _db.Salones on a.ID_SALON equals d.ID
                    where a.ACTIVO == 1 && a.FECHA == dateTimePicker1.Value
                    select new {
                        a,
                        APE_NOM = b.APELLIDO + ", " + b.NOMBRE,
                        TIPO = c.NOMBRE,
                        SALON = d.NOMBRE
                    };

            foreach (var item in P) {
                PrestamosEntity Entity = new PrestamosEntity(item.a);
                Entity.APE_NOM = item.APE_NOM;
                Entity.TIPO_PERSONA = item.TIPO;
                Entity.SALON = item.SALON;
                Entity.ButtonLB = "Dar de Baja";
                List.Add(Entity);
            }

            var Q = from a in _db.Reserva
                    join b in _db.Personas on a.ID_PERSONA equals b.ID
                    join c in _db.Tipos_Persona on b.ID_TIPO_PERSONA equals c.ID
                    join d in _db.Salones on a.ID_SALON equals d.ID
                    where a.FECHA_BAJA == null //falta agregar filtro de fecha seleccionada
                    && a.FECHA_RESERVA == dateTimePicker1.Value
                    select new {
                        a,
                        APE_NOM = b.APELLIDO + ", " + b.NOMBRE,
                        TIPO = c.NOMBRE,
                        SALON = d.NOMBRE
                    };

            foreach (var item in Q) {
                if (List.Any(x => x.ID_RESERVA == item.a.ID))
                    continue;

                PrestamosEntity Entity = new PrestamosEntity(item.a);
                Entity.APE_NOM = item.APE_NOM;
                Entity.TIPO_PERSONA = item.TIPO;
                Entity.SALON = item.SALON;
                Entity.ButtonLB = "Dar de Alta";

                List.Add(Entity);
            }

            dataGridView1.DataSource = List.OrderBy(x => x.H_DESDE).ToList();
            Registros_LB.Text = "Mostrando " + Q.Count().ToString() + " Reservas y " + P.Count().ToString() + " Prestamos Dados de Alta.";
        }

        private void OpenForm(Form form) {
            
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Location = new Point((this.Location.X + (this.Width / 2)) - (form.Width / 2), (this.Height / 2) - (form.Height / 2));
            form.TopMost = true;
            form.BringToFront();
            form.Show();
            form.Focus();
        }

        private string Baja(decimal id) {
            _db = new ProyectoresModelEntities();
            string response = "";
            try {
                Prestamos PEntity = _db.Prestamos.Where(x => x.ID == id).SingleOrDefault();
                PEntity.ACTIVO = 0;
                if (PEntity.ID_RESERVA != 0 && PEntity.ID_RESERVA != null) {
                    Reserva REntity = _db.Reserva.Where(z => z.ID == PEntity.ID_RESERVA).SingleOrDefault();
                    REntity.ID_MOTIVO_BAJA = 1;
                    REntity.FECHA_BAJA = DateTime.Now.Date;
                }
                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se Produjo un Error al Realizar la Baja.";
                throw;
            }
            return response;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex != dataGridView1.ColumnCount - 1)
                return;
            DataGridViewRow a = dataGridView1.Rows[e.RowIndex];
            int IsActivo = (int)a.Cells[7].Value;
            //si NO es un prestamo Activo, Abro el Form de Alta:
            if (IsActivo != 1) {
                InicioFormAlta form = new InicioFormAlta(a, this);
                OpenForm(form);
                return;
            }
            //Si es activo Activo, el boton se apreto para dar de baja:
            decimal ID = (decimal)a.Cells[0].Value;

            DialogResult D = MessageBox.Show("¿Desea Dar de Baja el Prestamo?", "Confirmacion Baja", MessageBoxButtons.YesNo);
            switch (D) {
                case DialogResult.Yes:
                    string response = Baja(ID);
                    if (response != "")
                        MessageBox.Show(response);
                    else MessageBox.Show("Baja Correcta.");
                    this.GetData();
                    break;
                default:
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            if (dateTimePicker1.Value.Date == DateTime.Now.Date)
                dateTimePicker1.CustomFormat = "'(Hoy) -' dd/MM/yyyy";
            else
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            GetData();
        }

        private void button2_Click(object sender, EventArgs e) {
            dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(1);
        }

        private void button1_Click(object sender, EventArgs e) {
            dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(-1);
        }

        private void button3_Click(object sender, EventArgs e) {
            dataGridView1.Rows[0].Cells[dataGridView1.ColumnCount - 1].Value = "lala";
            
        }

        private void AddBT_Click(object sender, EventArgs e) {
            InicioFormNew form = new InicioFormNew(this);
            OpenForm(form);
        }


    }
}
