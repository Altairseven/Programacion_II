using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectores.Classes;

namespace Proyectores.Forms.ABM {
    public partial class ProyectoresForm : Form {
        public ProyectoresForm() {
            InitializeComponent();
            SetupComboboxes();
        }

        private void ProyectoresForm_Load(object sender, EventArgs e) {

        }


        private void SetupComboboxes() {
            Db_ComboItem c1i1 = new Db_ComboItem(0, "No");
            Db_ComboItem c1i2 = new Db_ComboItem(1, "Si");
            Db_ComboItem c3i1 = new Db_ComboItem(0, "Descompuesto");
            Db_ComboItem c3i2 = new Db_ComboItem(1, "Funcional");
            List<Db_ComboItem> list = new List<Db_ComboItem>();
            list.Add(c1i1);
            list.Add(c1i2);
            dB_HDMI.DBItemList = list;
            dB_Dispo.DBItemList = list;
            list.Clear();
            list.Add(c3i1);
            list.Add(c3i2);
            dB_Estado.DBItemList = list;




        }


        private void Body_GroupBox_Enter(object sender, EventArgs e) {

        }
    }
}
