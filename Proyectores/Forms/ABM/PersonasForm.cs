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

namespace Proyectores.Forms.ABM
{
    public partial class PersonasForm : Form
    {
        public PersonasForm()
        {
            InitializeComponent();
        }

        ProyectoresModelEntities _db = new ProyectoresModelEntities();

        private void PersonasForm_Load(object sender, EventArgs e) {
            TipoDoc_CB.DataSource = _db.Tipo_Documento.ToList();
            Tipo_persona_CB.DataSource = _db.Tipos_Persona.OrderBy(x => x.NOMBRE).ToList();
        }
    }
}
