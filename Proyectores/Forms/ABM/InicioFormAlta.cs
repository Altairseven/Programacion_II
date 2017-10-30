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

namespace Proyectores.Forms.ABM {
    public partial class InicioFormAlta : Form {
        public InicioFormAlta() {
            InitializeComponent();
        }

        public DataGridViewRow Row { get; set; }
        ProyectoresModelEntities _db = new ProyectoresModelEntities();
        private InicioGrilla Grilla { get; set; }


        public InicioFormAlta(DataGridViewRow _renglon, InicioGrilla _grilla) {
            InitializeComponent();
            Row = _renglon;
            Grilla = _grilla;
            
        }
        private void PrestamosAlta_Load(object sender, EventArgs e) {
            if (Row != null)
                FeedData();
        }

        private void FeedData() {
            Persona_TB.Text = Row.Cells[13].Value.ToString();
            Tipo_TB.Text = Row.Cells[14].Value.ToString();
            D_TB.Text = ((DateTime)Row.Cells[5].Value).ToShortTimeString();
            H_TB.Text = ((DateTime)Row.Cells[6].Value).ToShortTimeString();
            Salon_TB.Text = Row.Cells[12].Value.ToString();
            P_CB.DataSource = _db.Proyectores.ToList();

        }

        private void BT_Save_Click(object sender, EventArgs e) {
            Prestamos Entity = new Prestamos();



            string response = "";
            try {
                Entity.ID_PERSONA = (decimal)Row.Cells[3].Value;
                Entity.ID_SALON = (decimal)Row.Cells[2].Value;
                Entity.ID_PROYECTOR = (decimal)P_CB.SelectedValue;
                Entity.H_DESDE = (DateTime)Row.Cells[5].Value;
                Entity.H_HASTA = (DateTime)Row.Cells[6].Value;
                Entity.FECHA = (DateTime)Row.Cells[8].Value;
                Entity.ACTIVO = 1;
                Entity.ID_RESERVA = (decimal)Row.Cells[4].Value;

                _db.Prestamos.Add(Entity);

                _db.Proyectores.Where(x => x.ID == Entity.ID_PROYECTOR).FirstOrDefault().DISPONIBLE = 0;
                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Ha ocurrido un Error";
                throw;
            }

            if (response != "") {
                MessageBox.Show(response);
                return;
            }
            else {
                MessageBox.Show("Alta Confirmada.");
            }

            this.Hide();
            Grilla.GetData();
            this.Dispose();

        }

        private void BT_Cancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Dispose();
        }
    }
}
