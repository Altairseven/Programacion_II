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
using System.Windows.Input;
using System.Windows.Media;

namespace Proyectores.Forms {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        List<PersonasEntity> list = new List<PersonasEntity>();

        private void Principal_Load(object sender, EventArgs e) {
            tabControl1.SendToBack();
            treeView1.SendToBack();
            treeView1.ExpandAll();
            int test = tabControl1.TabPages.Count;
            tabControl1.Hide();
            TabCloseBT.Hide();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            switch (e.Node.Name) {
                case "Localidades":
                    OpenTab("Proyectores.Forms.ABM.LocalidadGrilla");
                    break;
                case "Proyectores":
                    OpenTab("Proyectores.Forms.ABM.ProyectoresGrilla");
                    break;
                case "Personas":
                    OpenTab("Proyectores.Forms.ABM.PersonasGrilla");
                    break;
                default:
                    break;
            }
        }

        private void OpenTab(string TipoFormulario) {
            TabPage tab = new TabPage();
            tab.Text = treeView1.SelectedNode.Text;
            tabControl1.TabPages.Add(tab);
            tabControl1.Show();
            TabCloseBT.Show();
            Form form = (Form)Activator.CreateInstance(Type.GetType(TipoFormulario));
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            tabControl1.SelectedTab = tab;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e) {
            if (((TabControl)sender).TabCount <= 0)
                tabControl1.Hide();
            else
                tabControl1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            Close_Tab();
        }

        private void Close_Tab() {
            if (tabControl1.TabPages.Count == 0)
                return;

            TabPage tab = tabControl1.SelectedTab;
            int index = tabControl1.SelectedIndex;
            if (index <= 0)
                tabControl1.SelectedIndex += 1;
            else
                tabControl1.SelectedIndex -= 1;

            tabControl1.TabPages.Remove(tab);
            if (tabControl1.TabPages.Count == 0)
                tabControl1.SelectedIndex = -1;

            tab.Hide();
            tab.Dispose();
            

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (((TabControl)sender).TabCount <= 0) {
                tabControl1.Hide();
                TabCloseBT.Hide();
            }
                
            else
                tabControl1.Show();
        }


    }
}
