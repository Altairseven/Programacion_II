namespace Proyectores.Forms.ABM {
    partial class ReservasForm {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fecha_TB = new System.Windows.Forms.TextBox();
            this.H_MTB = new System.Windows.Forms.MaskedTextBox();
            this.D_MTB = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tipo_TB = new System.Windows.Forms.TextBox();
            this.Salon_TB = new System.Windows.Forms.TextBox();
            this.Persona_TB = new System.Windows.Forms.TextBox();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Registro_LB = new System.Windows.Forms.Label();
            this.BT_Ultimo = new System.Windows.Forms.Button();
            this.BT_Proximo = new System.Windows.Forms.Button();
            this.BT_Anterior = new System.Windows.Forms.Button();
            this.BT_Primero = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Fecha_TB);
            this.groupBox1.Controls.Add(this.H_MTB);
            this.groupBox1.Controls.Add(this.D_MTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tipo_TB);
            this.groupBox1.Controls.Add(this.Salon_TB);
            this.groupBox1.Controls.Add(this.Persona_TB);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 288);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha:";
            // 
            // Fecha_TB
            // 
            this.Fecha_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fecha_TB.BackColor = System.Drawing.SystemColors.Window;
            this.Fecha_TB.Enabled = false;
            this.Fecha_TB.Location = new System.Drawing.Point(237, 132);
            this.Fecha_TB.Name = "Fecha_TB";
            this.Fecha_TB.ReadOnly = true;
            this.Fecha_TB.Size = new System.Drawing.Size(203, 26);
            this.Fecha_TB.TabIndex = 33;
            // 
            // H_MTB
            // 
            this.H_MTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.H_MTB.Location = new System.Drawing.Point(373, 177);
            this.H_MTB.Mask = "00:00";
            this.H_MTB.Name = "H_MTB";
            this.H_MTB.Size = new System.Drawing.Size(67, 26);
            this.H_MTB.TabIndex = 25;
            this.H_MTB.ValidatingType = typeof(System.DateTime);
            this.H_MTB.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.D_MTB_TypeValidationCompleted);
            // 
            // D_MTB
            // 
            this.D_MTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.D_MTB.Location = new System.Drawing.Point(237, 177);
            this.D_MTB.Mask = "00:00";
            this.D_MTB.Name = "D_MTB";
            this.D_MTB.Size = new System.Drawing.Size(64, 26);
            this.D_MTB.TabIndex = 24;
            this.D_MTB.ValidatingType = typeof(System.DateTime);
            this.D_MTB.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.D_MTB_TypeValidationCompleted);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tipo Persona:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Salon:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "A Cargo de:";
            // 
            // Tipo_TB
            // 
            this.Tipo_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tipo_TB.BackColor = System.Drawing.SystemColors.Window;
            this.Tipo_TB.Enabled = false;
            this.Tipo_TB.Location = new System.Drawing.Point(237, 93);
            this.Tipo_TB.Name = "Tipo_TB";
            this.Tipo_TB.ReadOnly = true;
            this.Tipo_TB.Size = new System.Drawing.Size(203, 26);
            this.Tipo_TB.TabIndex = 27;
            // 
            // Salon_TB
            // 
            this.Salon_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Salon_TB.BackColor = System.Drawing.SystemColors.Window;
            this.Salon_TB.Location = new System.Drawing.Point(237, 217);
            this.Salon_TB.Name = "Salon_TB";
            this.Salon_TB.ReadOnly = true;
            this.Salon_TB.Size = new System.Drawing.Size(203, 26);
            this.Salon_TB.TabIndex = 26;
            this.Salon_TB.DoubleClick += new System.EventHandler(this.OnSearchDbClick);
            this.Salon_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearch_KeyDown);
            this.Salon_TB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSearch_KeyUp);
            // 
            // Persona_TB
            // 
            this.Persona_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Persona_TB.BackColor = System.Drawing.SystemColors.Window;
            this.Persona_TB.Location = new System.Drawing.Point(237, 53);
            this.Persona_TB.Name = "Persona_TB";
            this.Persona_TB.ReadOnly = true;
            this.Persona_TB.Size = new System.Drawing.Size(203, 26);
            this.Persona_TB.TabIndex = 23;
            this.Persona_TB.DoubleClick += new System.EventHandler(this.OnSearchDbClick);
            this.Persona_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearch_KeyDown);
            this.Persona_TB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSearch_KeyUp);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancel.Location = new System.Drawing.Point(520, 318);
            this.BT_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(86, 32);
            this.BT_Cancel.TabIndex = 26;
            this.BT_Cancel.Text = "Cancelar";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save.Location = new System.Drawing.Point(416, 318);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(94, 32);
            this.BT_Save.TabIndex = 25;
            this.BT_Save.Text = "Guardar";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // Registro_LB
            // 
            this.Registro_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Registro_LB.AutoSize = true;
            this.Registro_LB.Location = new System.Drawing.Point(217, 324);
            this.Registro_LB.Name = "Registro_LB";
            this.Registro_LB.Size = new System.Drawing.Size(77, 20);
            this.Registro_LB.TabIndex = 31;
            this.Registro_LB.Text = "<Entries>";
            // 
            // BT_Ultimo
            // 
            this.BT_Ultimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Ultimo.Location = new System.Drawing.Point(160, 318);
            this.BT_Ultimo.Name = "BT_Ultimo";
            this.BT_Ultimo.Size = new System.Drawing.Size(40, 32);
            this.BT_Ultimo.TabIndex = 30;
            this.BT_Ultimo.Text = ">>";
            this.BT_Ultimo.UseVisualStyleBackColor = true;
            this.BT_Ultimo.Click += new System.EventHandler(this.BT_Ultimo_Click);
            // 
            // BT_Proximo
            // 
            this.BT_Proximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Proximo.Location = new System.Drawing.Point(112, 318);
            this.BT_Proximo.Name = "BT_Proximo";
            this.BT_Proximo.Size = new System.Drawing.Size(40, 32);
            this.BT_Proximo.TabIndex = 29;
            this.BT_Proximo.Text = ">";
            this.BT_Proximo.UseVisualStyleBackColor = true;
            this.BT_Proximo.Click += new System.EventHandler(this.BT_Proximo_Click);
            // 
            // BT_Anterior
            // 
            this.BT_Anterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Anterior.Location = new System.Drawing.Point(64, 318);
            this.BT_Anterior.Name = "BT_Anterior";
            this.BT_Anterior.Size = new System.Drawing.Size(40, 32);
            this.BT_Anterior.TabIndex = 28;
            this.BT_Anterior.Text = "<";
            this.BT_Anterior.UseVisualStyleBackColor = true;
            this.BT_Anterior.Click += new System.EventHandler(this.BT_Anterior_Click);
            // 
            // BT_Primero
            // 
            this.BT_Primero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Primero.Location = new System.Drawing.Point(17, 318);
            this.BT_Primero.Name = "BT_Primero";
            this.BT_Primero.Size = new System.Drawing.Size(40, 32);
            this.BT_Primero.TabIndex = 27;
            this.BT_Primero.Text = "<<";
            this.BT_Primero.UseVisualStyleBackColor = true;
            this.BT_Primero.Click += new System.EventHandler(this.BT_Primero_Click);
            // 
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 362);
            this.ControlBox = false;
            this.Controls.Add(this.Registro_LB);
            this.Controls.Add(this.BT_Ultimo);
            this.Controls.Add(this.BT_Proximo);
            this.Controls.Add(this.BT_Anterior);
            this.Controls.Add(this.BT_Primero);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReservasForm";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox H_MTB;
        private System.Windows.Forms.MaskedTextBox D_MTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tipo_TB;
        private System.Windows.Forms.TextBox Salon_TB;
        private System.Windows.Forms.TextBox Persona_TB;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Label Registro_LB;
        private System.Windows.Forms.Button BT_Ultimo;
        private System.Windows.Forms.Button BT_Proximo;
        private System.Windows.Forms.Button BT_Anterior;
        private System.Windows.Forms.Button BT_Primero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Fecha_TB;
    }
}