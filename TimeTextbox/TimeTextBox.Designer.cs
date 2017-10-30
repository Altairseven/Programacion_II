namespace TimeTextbox {
    partial class TimeTextBox {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // TimeTextBox
            // 
            this.CursorChanged += new System.EventHandler(this.TimeTextBox_CursorChanged);
            this.Enter += new System.EventHandler(this.TimeTextBox_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Event);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
