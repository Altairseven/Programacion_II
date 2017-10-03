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
using Modelo.Model;

namespace Proyectores.Forms.ABM {
    public partial class LocalidadGrilla : Form {
        public LocalidadGrilla() {
            InitializeComponent();
        }

        //Referencia al Modelo
        private ProyectoresModelEntities _db = new ProyectoresModelEntities();
        //lista de Nuestra Entidad, q va a almacenar los datos de la tabla.
        private List<LocalidadesEntity> List;

        private void LocalidadGrilla_Load(object sender, EventArgs e) {
            GetData();
        }


        //este metodo va a manejar tanto la obtencion de datos desde la tabla, como la busqueda en los mismo
        public void GetData(){
            //Inicializamos la lista como lista nueva
             List = new List<LocalidadesEntity>();

            string query = "SELECT a.*, b.nombre as NOMBRE_PROVINCIA " +
                           "FROM Localidades a inner join Provincias b on a.ID_PROVINCIA = b.ID " +
                            "order by b.Nombre ASC, a.NOMBRE ASC";
            //Ejecutamos la consulta
            List = _db.Database.SqlQuery<LocalidadesEntity>(query).ToList();
            //Asignamos los resultados a la Datagridview
            dataGridView1.DataSource = List;

            #region BUSQUEDA EN LOS RESULTADOS

                //si el campo de busqueda no esta vacio:
                if (Search_TB.Text != "") { 
                
                //guardamos una copia de la lista en otra lista temporal
                //Cosa muy importante aca.. .. si no estuviera el .ToList(); del final, seria hacer referencia, y al borrar una, borrariamos las 2.

                List<LocalidadesEntity> TempList = List.ToList();
                //vaciamos los datos de la datagridview
                dataGridView1.DataSource = null;
                //vaciamos la lista original
                List.Clear();

                //a la lista.. que ahora esta vacia, le agregamos todos los elementos, de la copia de la lista,
                //que contengan el valor del search_TB, en su campo nombre.
                //basicamente estamos llenandola con los resultados de la busqueda.
                List.AddRange(TempList.Where(x => x.NOMBRE.ToLower().Contains(Search_TB.Text.Trim().ToLower())).ToList());
                //y si el valor de search_TB es numerico:
                Decimal cod;
                if (decimal.TryParse(Search_TB.Text, out cod)) {
                    //agregamos tambien los resultados de buscar por codigo postal.
                    List.AddRange(TempList.Where(x => x.COD_POSTAL == cod).ToList());
                }
                //asi entonces tenemos. con un solo campo de busqueda, resultados de buscar en mas de 1 columna de la tabla
                //en tablas mas complicadas, hacer es tan practico, y seria mejor poner un combo box, preguntado por que 
                //campo queres buscar
                
                if (List.Count != 0)
                    //si la lista no esta vacia, la reasignamos al datagridview
                    dataGridView1.DataSource = List;

                }
            #endregion  
                //mostramos la cantidad de resultados en el label.
            Lb_Info.Text = "Visualizando " + List.Count.ToString() + " Registros.";
        }

        private void EditBT_Click(object sender, EventArgs e) {
            //if (dataGridView1.SelectedRows.Count == 0) {
            //    MessageBox.Show("Seleccione un elemento.");
            //    return;
            //}


            OpenForm(true);
        }

        private void OpenForm(bool EditMode) {
            //Declaramos el form q vamos a abrir
            LocalidadForm form;
            //Localidades form, tiene 2 Modos de abrirse: 
            //El modo Add (para agregar una localidad y el modo Edit (para editar la localidad actual, 
            //y navegar entre toda la lista).

            //el primero necesita solo una referencia a este formulario osea.. un "this", 
            //el segundo, aparte del this, tmb recibe una referencia a List, y el id seleccionado

            //si editmode no es true (por eso el ! antes, seria igual a poner if(EditMode == false)
            if (!EditMode)
                //instanciamos el form en modo Add
                form = new LocalidadForm(this);
            else {
                // sino, y si hay un item seleccionado, lo instanciamos en modo Edit
                if (dataGridView1.SelectedRows.Count == 0) {
                    MessageBox.Show("Seleccione un elemento.");
                    return;
                }
                decimal id = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
                form = new LocalidadForm(id, List, this);
            }
            //Finalmente seteamos el form como un hijo de la ventana, para esto:
            //le sacamos la propiedad q hace q sea un padre(sino no podriamos)
            form.TopLevel = false;
            //lo agregamos a parentForm(q seria el formulario principal, acuerdense q estamos en la grilla, no en Principal
            ParentForm.Controls.Add(form);
            //le damos una ubicacion nueva(centrada, ponele.. )
            form.Location = new Point((this.Location.X + (this.Width / 2)) - (form.Width / 2), (this.Height / 2) - (form.Height / 2));
            //le decimos q este arriba de todo y siempre encima)
            form.TopMost = true;
            form.BringToFront();
            //y lo mostramos 
            form.Show();
            form.Focus();


        }

        private void AgregarBT_Click(object sender, EventArgs e) {
            OpenForm(false);
        }

        private void Search_TB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) {
                GetData();
            }
        }

        private void Search_TB_KeyUp(object sender, KeyEventArgs e) {
            if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && Search_TB.Text == "") {
                GetData();
            }
        }

        private void DelBT_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) {
                MessageBox.Show("Seleccione un elemento.");
                return;
            }
            
            // si preguntamos si seguro que quiere borrar, y si dice q si, llamamos a la funcion.
            DialogResult res = MessageBox.Show("¿Desea Eliminar el registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (res) {
                case DialogResult.OK:
                    string response = DB_Delete();
                    // si la respuesta que nos trajo no esta vacia, la mostramos, xq seria un cartel de error.
                    if (response != "")
                        MessageBox.Show(response,"",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else { 
                        //y si no avisamos q esta todo bien
                        MessageBox.Show("El registro ha sido borrado.");
                        // y refescramos la grilla.
                        GetData();
                    }
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        private string DB_Delete() {
            // creamos un string vacio.
            string response = "";
            decimal id = (decimal)dataGridView1.SelectedRows[0].Cells[0].Value;
            try {
                //buscamos en la base de datos por ID, trayendo el primero encontrado (q ovbiamente tmb es el inico, xq estamos buscando.. por ID)
                Localidades Entity = _db.Localidades.Where(x => x.ID == id).FirstOrDefault();
                //lo removemos de la tabla.
                _db.Localidades.Remove(Entity);
                // guardamos los cambios.
                _db.SaveChanges();
            }
            catch (Exception) {
                //solamente si algo crashea, el string de arriba se setea con este texto.
                response = "Ocurrio un error inesperado al borrar el registro.";
            }
            //devolvemos el string.
            return response;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e) {
            OpenForm(true);
        }


    }
}
