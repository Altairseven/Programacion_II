using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Model;
using Proyectores.Model.Entities;


namespace Proyectores.Forms.ABM {
    public partial class ProyectoresGrilla : Form {
        public ProyectoresGrilla() {
            InitializeComponent();
        }

        private ProyectoresModelEntities _db = new ProyectoresModelEntities();

        private List <ProyectoresEntity> List;



        private void ProyectoresGrilla_Load(object sender, EventArgs e) {
            GetData();
        }

        public void GetData() {

            List = new List<ProyectoresEntity>();

            var query = from a in _db.Proyectores
                        select a;

            

            foreach (Modelo.Model.Proyectores q in query) {
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

        private void AgregarBT_Click(object sender, EventArgs e) {
            ProyectoresForm a = new ProyectoresForm();
            a.Show();
        }
    }
}
