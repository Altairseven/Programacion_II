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

namespace Proyectores.Forms.ABM {
    public partial class LocalidadGrilla : Form {
        public LocalidadGrilla() {
            InitializeComponent();
        }

        Modelo.Model.ProyectoresModelEntities _db = new Modelo.Model.ProyectoresModelEntities();

        public decimal SelectedID { get; set; }

        public LocalidadGrilla(bool ischild) {
            InitializeComponent();
            if (ischild) SetupChild(this.bodyPanel);
        }

        private void SetupChild(Panel body) {
            body.Dock = DockStyle.None;
            body.Size = new Size(this.Width, this.Height);
            body.Anchor = AnchorStyles.Top;
            

        }

        private void LocalidadGrilla_Load(object sender, EventArgs e) {
            GetData();
        }
        private void GetData() {
            List<LocalidadesEntity> List = new List<LocalidadesEntity>();

            List = _db.Database.SqlQuery<LocalidadesEntity>("SELECT * FROM Localidades ORDER BY NOMBRE ASC").ToList();

            dataGridView1.DataSource = List;
            Lb_Info.Text = "Visualizando " + List.Count.ToString() + " Registros.";
        }

        private void EditBT_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //SelectedID = dataGridView1.SelectedCells[0].Value();
                
                
                }
    }
}
