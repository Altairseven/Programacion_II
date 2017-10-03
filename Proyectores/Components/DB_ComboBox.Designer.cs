namespace Proyectores.Components {
    partial class DB_ComboBox {
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
            // DB_ComboBox
            // 
            this.SelectedValueChanged += new System.EventHandler(this.DB_ComboBox_SelectedValueChanged);
            this.Enter += new System.EventHandler(this.DB_ComboBox_Enter);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
