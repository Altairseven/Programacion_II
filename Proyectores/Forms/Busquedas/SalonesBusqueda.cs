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
    public partial class SalonesBusqueda : Form {

        ProyectoresModelEntities _db = new ProyectoresModelEntities();
        List<SalonesEntity> List;
        IFormSalones Iform;


        public SalonesBusqueda() {
            InitializeComponent();
        }

        public SalonesBusqueda(IFormSalones _pform) {
            InitializeComponent();
            Iform = _pform;
            Search_TB.Focus();
        }


        private void LocalidadesBusqueda_Load(object sender, EventArgs e) {
            GetData();
            Search_TB.Focus();
        }

        public void GetData() {
            List = new List<SalonesEntity>();

            foreach (Salones item in _db.Salones.ToList()) {
                List.Add(new SalonesEntity(item));

            }

            dataGridView1.DataSource = List;


        }

        private void Search(string value) {
            if (Search_TB.Text == "") {
                GetData();
                return;
            }
            List<SalonesEntity> TempList = new List<SalonesEntity>();
            TempList.AddRange(List.Where(x => x.BusquedaContent.ToLower().Contains(value.Trim().ToLower())).ToList());

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
            SelectAndSend();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            SelectAndSend();
        }

        private void SelectAndSend() {
            Iform.ID_Salon = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
            Iform.Nombre_Salon = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
            this.Hide();
            this.Dispose();


        }

        private void SalonesBusqueda_Shown(object sender, EventArgs e) {
            Search_TB.Focus();
        }

        private void SalonesBusqueda_Enter(object sender, EventArgs e) {
            Search_TB.Focus();
        }
    }
}
