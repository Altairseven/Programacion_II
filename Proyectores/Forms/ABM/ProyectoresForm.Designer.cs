namespace Proyectores.Forms.ABM {
    partial class ProyectoresForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.BT_Ultimo = new System.Windows.Forms.Button();
            this.BT_Proximo = new System.Windows.Forms.Button();
            this.BT_Anterior = new System.Windows.Forms.Button();
            this.BT_Primero = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Body_GroupBox = new System.Windows.Forms.GroupBox();
            this.mTextBox_Edit1 = new Proyectores.Components.MTextBox_Edit();
            this.mTextBox_Edit2 = new Proyectores.Components.MTextBox_Edit();
            this.mTextBox_Edit3 = new Proyectores.Components.MTextBox_Edit();
            this.dB_Estado = new Proyectores.Components.DB_ComboBox();
            this.dB_Dispo = new Proyectores.Components.DB_ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dbComboItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_HDMI = new Proyectores.Components.DB_ComboBox();
            this.Body_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbComboItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Ultimo
            // 
            this.BT_Ultimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Ultimo.Location = new System.Drawing.Point(160, 352);
            this.BT_Ultimo.Name = "BT_Ultimo";
            this.BT_Ultimo.Size = new System.Drawing.Size(40, 32);
            this.BT_Ultimo.TabIndex = 13;
            this.BT_Ultimo.Text = ">>";
            this.BT_Ultimo.UseVisualStyleBackColor = true;
            // 
            // BT_Proximo
            // 
            this.BT_Proximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Proximo.Location = new System.Drawing.Point(112, 352);
            this.BT_Proximo.Name = "BT_Proximo";
            this.BT_Proximo.Size = new System.Drawing.Size(40, 32);
            this.BT_Proximo.TabIndex = 12;
            this.BT_Proximo.Text = ">";
            this.BT_Proximo.UseVisualStyleBackColor = true;
            // 
            // BT_Anterior
            // 
            this.BT_Anterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Anterior.Location = new System.Drawing.Point(64, 352);
            this.BT_Anterior.Name = "BT_Anterior";
            this.BT_Anterior.Size = new System.Drawing.Size(40, 32);
            this.BT_Anterior.TabIndex = 11;
            this.BT_Anterior.Text = "<";
            this.BT_Anterior.UseVisualStyleBackColor = true;
            // 
            // BT_Primero
            // 
            this.BT_Primero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Primero.Location = new System.Drawing.Point(16, 352);
            this.BT_Primero.Name = "BT_Primero";
            this.BT_Primero.Size = new System.Drawing.Size(40, 32);
            this.BT_Primero.TabIndex = 10;
            this.BT_Primero.Text = "<<";
            this.BT_Primero.UseVisualStyleBackColor = true;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancel.Location = new System.Drawing.Point(456, 344);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(80, 32);
            this.BT_Cancel.TabIndex = 9;
            this.BT_Cancel.Text = "Cancelar";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save.Location = new System.Drawing.Point(360, 344);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(80, 32);
            this.BT_Save.TabIndex = 8;
            this.BT_Save.Text = "Guardar";
            this.BT_Save.UseVisualStyleBackColor = true;
            // 
            // Body_GroupBox
            // 
            this.Body_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body_GroupBox.Controls.Add(this.dB_HDMI);
            this.Body_GroupBox.Controls.Add(this.label6);
            this.Body_GroupBox.Controls.Add(this.label5);
            this.Body_GroupBox.Controls.Add(this.label4);
            this.Body_GroupBox.Controls.Add(this.label3);
            this.Body_GroupBox.Controls.Add(this.label2);
            this.Body_GroupBox.Controls.Add(this.label1);
            this.Body_GroupBox.Controls.Add(this.dB_Dispo);
            this.Body_GroupBox.Controls.Add(this.dB_Estado);
            this.Body_GroupBox.Controls.Add(this.mTextBox_Edit3);
            this.Body_GroupBox.Controls.Add(this.mTextBox_Edit2);
            this.Body_GroupBox.Controls.Add(this.mTextBox_Edit1);
            this.Body_GroupBox.Location = new System.Drawing.Point(16, 16);
            this.Body_GroupBox.Name = "Body_GroupBox";
            this.Body_GroupBox.Size = new System.Drawing.Size(520, 320);
            this.Body_GroupBox.TabIndex = 7;
            this.Body_GroupBox.TabStop = false;
            this.Body_GroupBox.Text = "Alta Proyectores";
            this.Body_GroupBox.Enter += new System.EventHandler(this.Body_GroupBox_Enter);
            // 
            // mTextBox_Edit1
            // 
            this.mTextBox_Edit1.Location = new System.Drawing.Point(136, 40);
            this.mTextBox_Edit1.Name = "mTextBox_Edit1";
            this.mTextBox_Edit1.Size = new System.Drawing.Size(192, 26);
            this.mTextBox_Edit1.TabIndex = 0;
            // 
            // mTextBox_Edit2
            // 
            this.mTextBox_Edit2.Location = new System.Drawing.Point(136, 86);
            this.mTextBox_Edit2.Name = "mTextBox_Edit2";
            this.mTextBox_Edit2.Size = new System.Drawing.Size(352, 26);
            this.mTextBox_Edit2.TabIndex = 1;
            // 
            // mTextBox_Edit3
            // 
            this.mTextBox_Edit3.Location = new System.Drawing.Point(136, 132);
            this.mTextBox_Edit3.Name = "mTextBox_Edit3";
            this.mTextBox_Edit3.Size = new System.Drawing.Size(352, 26);
            this.mTextBox_Edit3.TabIndex = 2;
            // 
            // dB_Estado
            // 
            this.dB_Estado.DBItemList = null;
            this.dB_Estado.FormattingEnabled = true;
            this.dB_Estado.Location = new System.Drawing.Point(136, 274);
            this.dB_Estado.Name = "dB_Estado";
            this.dB_Estado.SelectedID = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dB_Estado.Size = new System.Drawing.Size(121, 28);
            this.dB_Estado.TabIndex = 4;
            // 
            // dB_Dispo
            // 
            this.dB_Dispo.DBItemList = null;
            this.dB_Dispo.FormattingEnabled = true;
            this.dB_Dispo.Location = new System.Drawing.Point(136, 226);
            this.dB_Dispo.Name = "dB_Dispo";
            this.dB_Dispo.SelectedID = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dB_Dispo.Size = new System.Drawing.Size(121, 28);
            this.dB_Dispo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hdmi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "N° Serie";
            // 
            // dbComboItemBindingSource
            // 
            this.dbComboItemBindingSource.DataSource = typeof(Proyectores.Classes.Db_ComboItem);
            // 
            // dB_HDMI
            // 
            this.dB_HDMI.DBItemList = null;
            this.dB_HDMI.FormattingEnabled = true;
            this.dB_HDMI.Location = new System.Drawing.Point(136, 176);
            this.dB_HDMI.Name = "dB_HDMI";
            this.dB_HDMI.SelectedID = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dB_HDMI.Size = new System.Drawing.Size(121, 28);
            this.dB_HDMI.TabIndex = 12;
            // 
            // ProyectoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 393);
            this.Controls.Add(this.BT_Ultimo);
            this.Controls.Add(this.BT_Proximo);
            this.Controls.Add(this.BT_Anterior);
            this.Controls.Add(this.BT_Primero);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.Body_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProyectoresForm";
            this.Load += new System.EventHandler(this.ProyectoresForm_Load);
            this.Body_GroupBox.ResumeLayout(false);
            this.Body_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbComboItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Ultimo;
        private System.Windows.Forms.Button BT_Proximo;
        private System.Windows.Forms.Button BT_Anterior;
        private System.Windows.Forms.Button BT_Primero;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.GroupBox Body_GroupBox;
        private Components.MTextBox_Edit mTextBox_Edit1;
        private Components.MTextBox_Edit mTextBox_Edit3;
        private Components.MTextBox_Edit mTextBox_Edit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Components.DB_ComboBox dB_Dispo;
        private Components.DB_ComboBox dB_Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dbComboItemBindingSource;
        private Components.DB_ComboBox dB_HDMI;
    }
}