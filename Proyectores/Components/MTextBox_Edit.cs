﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyectores.Components {
    public partial class MTextBox_Edit : MaskedTextBox {
        public MTextBox_Edit() {
            InitializeComponent();

        }
        private void keydownevent(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) {
                SendKeys.Send("{TAB}");
                //e.SuppressKeyPress = true;
            }
        }
        private void OnEnter(object sender, EventArgs e) {
                this.SelectAll();

            //Otra Forma de hacerlo, es con esto:

                //this.SelectionStart = 0;
                //this.SelectionLength = this.Text.Length;
        }

        private void MTextBox_Edit_Click(object sender, EventArgs e) {
            this.Focus();
        }
    }
}
