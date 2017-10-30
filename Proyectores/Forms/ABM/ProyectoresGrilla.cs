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
    public partial class ProyectoresGrilla : Form, IGrilla {
        public ProyectoresGrilla() {
            InitializeComponent();
        }

        ProyectoresModelEntities _db;

        private List <ProyectoresEntity> List;

        private void ProyectoresGrilla_Load(object sender, EventArgs e) {
            
        }

        public void GetData() {
        

        List = new List<ProyectoresEntity>();
            _db = new ProyectoresModelEntities();

            var query = from a in _db.Proyectores
                        select a;

            foreach (Model.Proyectores q in query) {
                ProyectoresEntity item = new ProyectoresEntity(q);
                if (item.DISPONIBLE == 1) item.DISPONIBLEstr = "Si";
                else item.DISPONIBLEstr = "No";
                if (item.OPERATIVO == 1) item.OPERATIVOstr = "Funcional";
                else item.OPERATIVOstr = "Descompuesto";
                if (item.HDMI == 1) item.HDMIstr = "Si";
                else item.HDMIstr = "No";
                List.Add(item);
            }
            dataGridView1.DataSource = List;
        }

        private string DB_Delete() {
            _db = new ProyectoresModelEntities();

            string response = "";
            decimal id = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
            try {
                Model.Proyectores Entity = _db.Proyectores.Where(x => x.ID == id).FirstOrDefault();
                _db.Proyectores.Remove(Entity);
                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error.";
                throw;
            }

            return response;
        }

        private void OpenForm(bool EditMode) {

            ProyectoresForm form;

            if (!EditMode)

                form = new ProyectoresForm(this);
            else {

                if (dataGridView1.SelectedRows.Count == 0) {
                    MessageBox.Show("Seleccione un elemento.");
                    return;
                }
                decimal id = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
                form = new ProyectoresForm(this, id, List);
            }

            form.TopLevel = false;
            ParentForm.Controls.Add(form);
            form.Location = new Point((this.Location.X + (this.Width / 2)) - (form.Width / 2), (this.Height / 2) - (form.Height / 2));
            form.TopMost = true;
            form.BringToFront();
            form.Show();
            form.Focus();
        }


        //Eventos
        private void AgregarBT_Click(object sender, EventArgs e) {
            OpenForm(false);
        }

        private void EditBT_Click(object sender, EventArgs e) {
            OpenForm(true);
        }

        private void button1_Click(object sender, EventArgs e) {
            GetData();
        }

        private void DelBT_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) {
                MessageBox.Show("Seleccione un elemento.");
                return;
            }
            DialogResult res = MessageBox.Show("¿Desea Eliminar el registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (res) {
                case DialogResult.OK:
                    string response = DB_Delete();
                    if (response != "")
                        MessageBox.Show(response, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else {
                        MessageBox.Show("El registro ha sido borrado.");
                        GetData();
                    }
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

    }
}
