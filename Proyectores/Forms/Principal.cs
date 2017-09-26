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
using Proyectores.Forms.Proyectores;

namespace Proyectores.Forms {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        ProyectoresModelEntities _db = new ProyectoresModelEntities();

        List<PersonasEntity> list = new List<PersonasEntity>();

        private void Principal_Load(object sender, EventArgs e) {
            GetList();
                        
        }

        public void GetList() {

            string sqlquery = "select a.*, b.NOMBRE as LocNombre , c.NOMBRE as DocNombre, d.NOMBRE as TIPO_PERSONA from personas a " +
                              "inner join Localidades b on a.ID_LOCALIDAD = b.ID " +
                              "inner join Tipo_Documento c on a.ID_TIPO_DOCUMENTO = c.ID " +
                              "inner join Tipos_Persona d on a.ID_TIPO_Persona = d.ID";

            list = _db.Database.SqlQuery<PersonasEntity>(sqlquery).ToList();


        }

        private void On_DBCLick(object sender, EventArgs e) {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            int id = treeView1.SelectedNode.Index;

            if(id == 1) {
                LocalidadForm form = new LocalidadForm();
                
                TabPage tab = new TabPage();
                tabControl1.TabPages.Add(tab);
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                tab.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();

            }

        }
    }
}
