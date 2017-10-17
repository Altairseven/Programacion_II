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

        ProyectoresModelEntities _db = new ProyectoresModelEntities();
        List<PrestamosEntity> List;

        public void GetData() {
            List = new List<PrestamosEntity>();
            IEnumerable<Reserva> _list2 = new List<Reserva>();

            var q = from a in _db.Reserva
                     join b in _db.Personas on a.ID_PERSONA equals b.ID
                     join c in _db.Tipos_Persona on b.ID_TIPO_PERSONA equals c.ID
                     join d in _db.Salones on a.ID_SALON equals d.ID
                     where a.FECHA_BAJA == null //falta agregar filtro de fecha seleccionada
                     select new {
                         a,
                         APE_NOM = b.APELLIDO + ", " + b.NOMBRE,
                         TIPO = c.NOMBRE,
                         SALON = d.NOMBRE


                     };

            foreach (var item in q) {
                PrestamosEntity Entity = new PrestamosEntity(item.a);
                Entity.APE_NOM = item.APE_NOM;
                Entity.TIPO_PERSONA = item.TIPO;
                Entity.SALON = item.SALON;
                Entity.ButtonLB = "Dar de Alta";

                List.Add(Entity);
            }

            dataGridView1.DataSource = List;
        }












        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex != dataGridView1.ColumnCount - 1)
                return;
            DataGridViewRow a = dataGridView1.Rows[e.RowIndex];
            MessageBox.Show(a.Cells[2].Value.ToString() + a.Cells[3].Value.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            if (dateTimePicker1.Value.Date == DateTime.Now.Date)
                dateTimePicker1.CustomFormat = "'(Hoy) -' dd/MM/yyyy";
            else
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void button2_Click(object sender, EventArgs e) {
            dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(1);
        }

        private void button1_Click(object sender, EventArgs e) {
            dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(-1);
        }

        private void InicioGrilla_Load(object sender, EventArgs e) {
            GetData();
        }

        private void button3_Click(object sender, EventArgs e) {
            dataGridView1.Rows[0].Cells[dataGridView1.ColumnCount - 1].Value = "lala";
            
        }

        private void prestamosEntityBindingSource_CurrentChanged(object sender, EventArgs e) {

        }
    }
}
