using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectores.Forms.ABM {
    public partial class LocalidadForm : Form {
        public LocalidadForm() {
            InitializeComponent();
            this.TopLevel = false;

        }
        public LocalidadForm(bool AsChild) {
            InitializeComponent();
            if (AsChild)
                SetupChild(Body);
        }

        private void SetupChild(Panel body) {
            body.Dock = DockStyle.None;
            body.Size = new Size(this.Width, this.Height);
            body.Anchor = AnchorStyles.Top;

        }


        private void LocalidadForm_Load(object sender, EventArgs e) {

        }
    }
}
