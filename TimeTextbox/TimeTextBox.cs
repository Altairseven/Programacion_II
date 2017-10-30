using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTextbox {
    public partial class TimeTextBox : MaskedTextBox {
        public TimeTextBox() {
            InitializeComponent();
            TextAlign = HorizontalAlignment.Center;
            this.Mask = "00:00";
            this.ValidatingType = typeof(DateTime);
            this.TypeValidationCompleted += new TypeValidationEventHandler(TypeValidationCompleted_Event);
            this.KeyDown += new KeyEventHandler(KeyDown_Event);
        }


        private void TypeValidationCompleted_Event(object sender, TypeValidationEventArgs e) {
            if (!e.IsValidInput)
                BackColor = Color.Khaki;
        }
        private void KeyDown_Event(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Right:
                    SelectionStart = this.Text.Length - 3;
                    SelectionLength = 2;

                    break;
                case Keys.Left:
                    
                    SelectionStart = 0;
                    SelectionLength = 2;

                    break;
                default:
                    break;
            }
        }
        //focus enter
        private void TimeTextBox_Enter(object sender, EventArgs e) {
            SelectAll();
            SelectionStart = 0;
            SelectionLength = 2;
            BackColor = SystemColors.Window;
        }

        private void TimeTextBox_CursorChanged(object sender, EventArgs e) {

        }
    }
}
