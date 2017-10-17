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

namespace Proyectores.Forms.Busquedas {
    public partial class LocalidadesBusqueda : Form {

        ProyectoresModelEntities _db = new ProyectoresModelEntities();
        List<LocalidadesEntity> List;
        IForms Pform;


        public LocalidadesBusqueda() {
            InitializeComponent();
        }

        public LocalidadesBusqueda(IForms _pform) {
            InitializeComponent();
            Pform = _pform;
            Search_TB.Focus();
        }


        private void LocalidadesBusqueda_Load(object sender, EventArgs e) {
            GetData();
            Search_TB.Focus();
        }

        public void GetData() {
            List = new List<LocalidadesEntity>();

            string query = "SELECT a.*, b.nombre as NOMBRE_PROVINCIA " +
                           "FROM Localidades a inner join Provincias b on a.ID_PROVINCIA = b.ID " +
                            "order by b.Nombre ASC, a.NOMBRE ASC";

            List = _db.Database.SqlQuery<LocalidadesEntity>(query).ToList();
            dataGridView1.DataSource = List;


        }

        private void Search(string value) {
            if (Search_TB.Text == "") {
                GetData();
                return;
            }
            List<LocalidadesEntity> TempList = new List<LocalidadesEntity>();
            dataGridView1.DataSource = null;

            TempList.AddRange(List.Where(x => x.NOMBRE.ToLower().Contains(value.Trim().ToLower())).ToList());
            Decimal cod;
            if (decimal.TryParse(value, out cod)) {
                TempList.AddRange(List.Where(x => x.COD_POSTAL == cod).ToList());
            }

            if (List.Count != 0)
                dataGridView1.DataSource = TempList;
        }

        private void On_Tb_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) {
                dataGridView1.Focus();
                return;
            }


            Search(Search_TB.Text);
        }

        private void OnGrid_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter || e.KeyCode != Keys.Return)
                return;


            Pform.Loc_ID = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
            Pform.COD_Postal = (decimal)dataGridView1.SelectedRows[0].Cells[1].Value;
            Pform.Loc_Nombre = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
            this.Hide();
            this.Dispose();

        }
    }
}
