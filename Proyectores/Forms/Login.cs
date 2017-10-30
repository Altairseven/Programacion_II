using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectores.Forms {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //validaciones




            //login check


            success(3m);
        }

        private void success(decimal id) {

            Main formularito = new Main(id);
            formularito.Show();
            this.Hide();

        }



    }
}
