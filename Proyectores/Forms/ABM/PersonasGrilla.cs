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


namespace Proyectores.Forms.ABM
{
    public partial class PersonasGrilla : Form
    {
        public PersonasGrilla()

        {
            InitializeComponent();
        }
        private ProyectoresModelEntities _db = new ProyectoresModelEntities();
        private List<PersonasEntity> List;
        private void PersonasGrilla_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            List=new List<PersonasEntity> ();

            string query = " select a.*, b.NOMBRE as DOCNOMBRE, c.NOMBRE as LOCNOMBRE, d.NOMBRE AS TIPO_PERSONA " +
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

        private void OpenForm(bool editmode)
        {

        }
    }

       
}
