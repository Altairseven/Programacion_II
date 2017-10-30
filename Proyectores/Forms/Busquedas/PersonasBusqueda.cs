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
    public partial class PersonasBusqueda : Form {

        ProyectoresModelEntities _db = new ProyectoresModelEntities();
        List<PersonasEntity> List;
        IFormPersonas Iform;


        public PersonasBusqueda() {
            InitializeComponent();
        }

        public PersonasBusqueda(IFormPersonas _pform) {
            InitializeComponent();
            Iform = _pform;
            Search_TB.Focus();
        }


        private void LocalidadesBusqueda_Load(object sender, EventArgs e) {
            GetData();
            Search_TB.Focus();
        }

        public void GetData() {
            List = new List<PersonasEntity>();

            string query = "select (b.NOMBRE + 'Ç' + a.NOMBRE + 'Ç' + a.APELLIDO + 'Ç' + ISNULL(CAST(a.LEGAJO as nvarchar(30)), '') + 'Ç' + ISNULL(CAST(a.legajo as nvarchar(30)), '') ) as BusquedaContent, " +
                           "b.NOMBRE as TIPO_PERSONA, a.* , (a.APELLIDO + ', ' + a.NOMBRE) AS APE_NOM, (c.NOMBRE + ' - ' + CAST(a.DOCUMENTO as nvarchar(30))) as DOCUMENTO_FULL " +
                           "from Personas a inner join Tipos_Persona b on a.ID_TIPO_PERSONA = b.ID " +
                           "inner join Tipo_Documento c on a.ID_TIPO_DOCUMENTO = c.ID ";

            List = _db.Database.SqlQuery<PersonasEntity>(query).ToList();
            dataGridView1.DataSource = List;


        }

        private void Search(string value) {
            if (Search_TB.Text == "") {
                GetData();
                return;
            }
            List<PersonasEntity> TempList = new List<PersonasEntity>();
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


        private void dataGridView1_Click(object sender, EventArgs e) {
            SelectAndSend();
        }

        private void SelectAndSend() {
            Iform.ID_Persona = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
            Iform.P_Nombre = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
            Iform.P_Apellido = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
            Iform.Nombre_Tipo_Persona = (string)dataGridView1.SelectedRows[0].Cells[13].Value;
            this.Hide();
            this.Dispose();


        }

        private void PersonasBusqueda_Enter(object sender, EventArgs e) {
            Search_TB.Focus();
        }

        private void PersonasBusqueda_Shown(object sender, EventArgs e) {
            Search_TB.Focus();
        }


    }
}
