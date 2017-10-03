using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectores.Classes;

namespace Proyectores.Components {
    public partial class DB_ComboBox : ComboBox {

        public decimal SelectedID { get; set; }
        private List<Db_ComboItem> _dbItemlist;
        public List<Db_ComboItem> DBItemList {
            get { return _dbItemlist; }
            set {
                _dbItemlist = value;
                if (_dbItemlist == null)
                    return;
                foreach (Db_ComboItem item in _dbItemlist) {
                    this.Items.Add(item.Text);
                }


            }
        }

        public DB_ComboBox() {
            InitializeComponent();
        }

        private void DB_ComboBox_SelectedValueChanged(object sender, EventArgs e) {
            SelectedID = _dbItemlist[this.SelectedIndex].ID;
        }

        private void DB_ComboBox_Enter(object sender, EventArgs e) {
            this.DroppedDown = true;
        }

        //private void DB_ComboBox_KeyDown(object sender, KeyEventArgs e) {
        //    if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)) {
        //        this.DroppedDown = true;
        //    }
        //}
    }
}
