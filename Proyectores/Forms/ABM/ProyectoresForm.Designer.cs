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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dbComboItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nserie_TB = new Proyectores.Components.MTextBox_Edit();
            this.Modelo_TB = new Proyectores.Components.MTextBox_Edit();
            this.Marca_TB = new Proyectores.Components.MTextBox_Edit();
            this.Registro_LB = new System.Windows.Forms.Label();
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
            this.BT_Ultimo.Click += new System.EventHandler(this.BT_Ultimo_Click);
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
            this.BT_Proximo.Click += new System.EventHandler(this.BT_Proximo_Click);
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
            this.BT_Anterior.Click += new System.EventHandler(this.BT_Anterior_Click);
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
            this.BT_Primero.Click += new System.EventHandler(this.BT_Primero_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancel.Location = new System.Drawing.Point(485, 352);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(80, 32);
            this.BT_Cancel.TabIndex = 9;
            this.BT_Cancel.Text = "Cancelar";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save.Location = new System.Drawing.Point(389, 352);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(80, 32);
            this.BT_Save.TabIndex = 8;
            this.BT_Save.Text = "Guardar";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // Body_GroupBox
            // 
            this.Body_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body_GroupBox.Controls.Add(this.comboBox3);
            this.Body_GroupBox.Controls.Add(this.comboBox2);
            this.Body_GroupBox.Controls.Add(this.comboBox1);
            this.Body_GroupBox.Controls.Add(this.label6);
            this.Body_GroupBox.Controls.Add(this.label5);
            this.Body_GroupBox.Controls.Add(this.label4);
            this.Body_GroupBox.Controls.Add(this.label3);
            this.Body_GroupBox.Controls.Add(this.label2);
            this.Body_GroupBox.Controls.Add(this.label1);
            this.Body_GroupBox.Controls.Add(this.Nserie_TB);
            this.Body_GroupBox.Controls.Add(this.Modelo_TB);
            this.Body_GroupBox.Controls.Add(this.Marca_TB);
            this.Body_GroupBox.Location = new System.Drawing.Point(16, 16);
            this.Body_GroupBox.Name = "Body_GroupBox";
            this.Body_GroupBox.Size = new System.Drawing.Size(549, 320);
            this.Body_GroupBox.TabIndex = 7;
            this.Body_GroupBox.TabStop = false;
            this.Body_GroupBox.Text = "Alta Proyectores";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.dbComboItemBindingSource;
            this.comboBox3.DisplayMember = "Text";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(152, 271);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.ValueMember = "ID";
            // 
            // dbComboItemBindingSource
            // 
            this.dbComboItemBindingSource.DataSource = typeof(Proyectores.Classes.Db_ComboItem);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.dbComboItemBindingSource;
            this.comboBox2.DisplayMember = "Text";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 223);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.dbComboItemBindingSource;
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disponible";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hdmi";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "N° Serie";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marca";
            // 
            // Nserie_TB
            // 
            this.Nserie_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nserie_TB.Location = new System.Drawing.Point(152, 131);
            this.Nserie_TB.Name = "Nserie_TB";
            this.Nserie_TB.Size = new System.Drawing.Size(352, 26);
            this.Nserie_TB.TabIndex = 2;
            // 
            // Modelo_TB
            // 
            this.Modelo_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modelo_TB.Location = new System.Drawing.Point(152, 85);
            this.Modelo_TB.Name = "Modelo_TB";
            this.Modelo_TB.Size = new System.Drawing.Size(352, 26);
            this.Modelo_TB.TabIndex = 1;
            // 
            // Marca_TB
            // 
            this.Marca_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Marca_TB.Location = new System.Drawing.Point(152, 39);
            this.Marca_TB.Name = "Marca_TB";
            this.Marca_TB.Size = new System.Drawing.Size(192, 26);
            this.Marca_TB.TabIndex = 0;
            // 
            // Registro_LB
            // 
            this.Registro_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registro_LB.AutoSize = true;
            this.Registro_LB.Location = new System.Drawing.Point(208, 358);
            this.Registro_LB.Name = "Registro_LB";
            this.Registro_LB.Size = new System.Drawing.Size(77, 20);
            this.Registro_LB.TabIndex = 14;
            this.Registro_LB.Text = "<Entries>";
            // 
            // ProyectoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 393);
            this.Controls.Add(this.Registro_LB);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Ultimo;
        private System.Windows.Forms.Button BT_Proximo;
        private System.Windows.Forms.Button BT_Anterior;
        private System.Windows.Forms.Button BT_Primero;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.GroupBox Body_GroupBox;
        private Components.MTextBox_Edit Marca_TB;
        private Components.MTextBox_Edit Nserie_TB;
        private Components.MTextBox_Edit Modelo_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dbComboItemBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Registro_LB;
    }
}