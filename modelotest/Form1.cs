using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelotest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();






        }

        ModeloTest _db = new ModeloTest();

        private void Form1_Load(object sender, EventArgs e) {
            List<Localidades> listita = _db.Localidades.ToList();


            int a;



        }
    }
}
