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
using Proyectores.Forms.ABM;

namespace Proyectores.Forms {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        List<PersonasEntity> list = new List<PersonasEntity>();

        private void Principal_Load(object sender, EventArgs e) {

              
        }

        private void On_DBCLick(object sender, EventArgs e) {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            int id = treeView1.SelectedNode.Index;

            if(id == 1) {
                LocalidadGrilla form = new LocalidadGrilla(true);
                
                TabPage tab = new TabPage();
                tabControl1.TabPages.Add(tab);
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                tab.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
                tabControl1.SelectedTab = tab;
                tab.Text = form.Text;

            }

        }

        private void button1_Click(object sender, EventArgs e) {
            LocalidadForm form = new LocalidadForm();
            form.Show();
        }
    }
}
