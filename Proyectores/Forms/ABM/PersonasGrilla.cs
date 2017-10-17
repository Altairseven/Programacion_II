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
using Proyectores.Model;


namespace Proyectores.Forms.ABM
{
    public partial class PersonasGrilla : Form, IGrilla {
        public PersonasGrilla()

        {
            InitializeComponent();
        }
        private ProyectoresModelEntities _db = new ProyectoresModelEntities();
        private List<PersonasEntity> List;

        private void PersonasGrilla_Load(object sender, EventArgs e) {
            GetData();
            this.ParentForm.KeyUp += new KeyEventHandler(this.HotKey_Listener);

        }

        private void HotKey_Listener(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.F2:
                    if (e.Modifiers == Keys.None) OpenForm(false);
                    break;
                case Keys.F3:
                    if (e.Modifiers == Keys.None) OpenForm(true);
                    break;
                case Keys.F4:
                    if (e.Modifiers == Keys.None) DelBT_Click(sender, new EventArgs());
                    break;
                case Keys.F:
                    if (e.Modifiers == Keys.Control) Search_TB.Focus();
                    break;
                default:
                    break;
            }

            //switch (e.KeyData) {
            //    case Keys.F2:
            //        OpenForm(false);
            //        break;
            //    case Keys.F3:
            //        OpenForm(true);
            //        break;
            //    case Keys.F4:
            //        DelBT_Click(sender, new EventArgs());
            //        break;
            //    case Keys.F | Keys.Control:
            //        Search_TB.Focus();
            //        break;
            //    default:
            //        break;
            //}

        }

        public void GetData()
        {
            List=new List<PersonasEntity> ();

            string query = " select a.*, b.NOMBRE as DOCNOMBRE, c.NOMBRE as LOCNOMBRE, d.NOMBRE AS TIPO_PERSONA, " +
                "CONCAT(a.APELLIDO, ', ', a.NOMBRE) as APE_NOM " + 
                "from Personas a " +
                "inner join Tipo_Documento b on a.ID_TIPO_DOCUMENTO = b.ID " +
                "inner join Localidades c on a.ID_LOCALIDAD = c.ID " +
                "inner join Tipos_Persona d on a.ID_TIPO_PERSONA = d.ID " ;
            List = _db.Database.SqlQuery<PersonasEntity>(query).ToList();

            dataGridView1.DataSource = List;

            /*#region BUSQUEDA EN LOS RESULTADOS
            if (Search_TB.Text != "")
            {

                

                List<PersonasEntity> TempList = List.ToList();
                
                dataGridView1.DataSource = null;
                
                List.Clear();

               
                List.AddRange(TempList.Where(x => x.NOMBRE.ToLower().Contains(Search_TB.Text.Trim().ToLower())).ToList());
                
                Decimal cod;
                if (decimal.TryParse(Search_TB.Text, out cod))
                {
                    
                    List.AddRange(TempList.Where(x => x.ID_LOCALIDAD == cod).ToList());
                }
              

                if (List.Count != 0)
                 iew
                    dataGridView1.DataSource = List;

            }
            #endregion*/
            
            Lb_Info.Text = "Visualizando " + List.Count.ToString() + " Registros.";

        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            OpenForm(true);
        }

        private void OpenForm(bool EditMode)
        {

            PersonasForm form;

            if (!EditMode)

                form = new PersonasForm(this);
            else
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un elemento.");
                    return;
                }
                decimal id = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
                form = new PersonasForm(id, List, this);
            }

            form.TopLevel = false;
            ParentForm.Controls.Add(form);
            form.Location = new Point((this.Location.X + (this.Width / 2)) - (form.Width / 2), (this.Height / 2) - (form.Height / 2));
            form.TopMost = true;
            form.BringToFront();
            form.Show();
            form.Focus();


        }

        private void AgregarBT_Click(object sender, EventArgs e) {
            OpenForm(false);
        }

        private string DB_Delete() {
            string response = "";
            decimal id = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
            try {
                Personas Entity = _db.Personas.Where(x => x.ID == id).FirstOrDefault();
                _db.Personas.Remove(Entity);
                _db.SaveChanges();
            }
            catch (Exception) {
                response = "Se ha producido un error.";
                throw;
            }

            return response;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e) {
            OpenForm(true);
        }
    }

       
}
