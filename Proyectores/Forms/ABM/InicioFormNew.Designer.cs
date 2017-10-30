namespace Proyectores.Forms.ABM {
    partial class InicioFormNew {
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
            this.H_MTB = new System.Windows.Forms.MaskedTextBox();
            this.D_MTB = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P_CB = new System.Windows.Forms.ComboBox();
            this.Tipo_TB = new System.Windows.Forms.TextBox();
            this.Salon_TB = new System.Windows.Forms.TextBox();
            this.Persona_TB = new System.Windows.Forms.TextBox();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.H_MTB);
            this.groupBox1.Controls.Add(this.D_MTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.P_CB);
            this.groupBox1.Controls.Add(this.Tipo_TB);
            this.groupBox1.Controls.Add(this.Salon_TB);
            this.groupBox1.Controls.Add(this.Persona_TB);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Prestamo";
            // 
            // H_MTB
            // 
            this.H_MTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.H_MTB.Location = new System.Drawing.Point(325, 129);
            this.H_MTB.Mask = "00:00";
            this.H_MTB.Name = "H_MTB";
            this.H_MTB.Size = new System.Drawing.Size(64, 26);
            this.H_MTB.TabIndex = 3;
            this.H_MTB.ValidatingType = typeof(System.DateTime);
            this.H_MTB.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.D_MTB_TypeValidationCompleted);
            // 
            // D_MTB
            // 
            this.D_MTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.D_MTB.Location = new System.Drawing.Point(189, 129);
            this.D_MTB.Mask = "00:00";
            this.D_MTB.Name = "D_MTB";
            this.D_MTB.Size = new System.Drawing.Size(64, 26);
            this.D_MTB.TabIndex = 2;
            this.D_MTB.ValidatingType = typeof(System.DateTime);
            this.D_MTB.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.D_MTB_TypeValidationCompleted);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tipo Persona:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Proyectores:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Salon:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "A Cargo de:";
            // 
            // P_CB
            // 
            this.P_CB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_CB.DisplayMember = "ID";
            this.P_CB.FormattingEnabled = true;
            this.P_CB.Location = new System.Drawing.Point(189, 209);
            this.P_CB.Name = "P_CB";
            this.P_CB.Size = new System.Drawing.Size(203, 28);
            this.P_CB.TabIndex = 5;
            this.P_CB.ValueMember = "ID";
            this.P_CB.Enter += new System.EventHandler(this.CB_Enter);
            // 
            // Tipo_TB
            // 
            this.Tipo_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tipo_TB.BackColor = System.Drawing.SystemColors.Window;
            this.Tipo_TB.Enabled = false;
            this.Tipo_TB.Location = new System.Drawing.Point(189, 89);
            this.Tipo_TB.Name = "Tipo_TB";
            this.Tipo_TB.ReadOnly = true;
            this.Tipo_TB.Size = new System.Drawing.Size(203, 26);
            this.Tipo_TB.TabIndex = 15;
            // 
            // Salon_TB
            // 
            this.Salon_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Salon_TB.BackColor = System.Drawing.SystemColors.Window;
            this.Salon_TB.Location = new System.Drawing.Point(189, 169);
            this.Salon_TB.Name = "Salon_TB";
            this.Salon_TB.ReadOnly = true;
            this.Salon_TB.Size = new System.Drawing.Size(203, 26);
            this.Salon_TB.TabIndex = 4;
            this.Salon_TB.DoubleClick += new System.EventHandler(this.OnSearchDbClick);
            // 
            // Persona_TB
            // 
            this.Persona_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Persona_TB.BackColor = System.Drawing.SystemColors.Window;
            this.Persona_TB.Location = new System.Drawing.Point(189, 49);
            this.Persona_TB.Name = "Persona_TB";
            this.Persona_TB.ReadOnly = true;
            this.Persona_TB.Size = new System.Drawing.Size(203, 26);
            this.Persona_TB.TabIndex = 1;
            this.Persona_TB.DoubleClick += new System.EventHandler(this.OnSearchDbClick);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancel.Location = new System.Drawing.Point(408, 320);
            this.BT_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(86, 32);
            this.BT_Cancel.TabIndex = 7;
            this.BT_Cancel.Text = "Cancelar";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save.Location = new System.Drawing.Point(304, 320);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(94, 32);
            this.BT_Save.TabIndex = 6;
            this.BT_Save.Text = "Confirmar";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // InicioFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(512, 364);
            this.ControlBox = false;
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InicioFormNew";
            this.Text = " ";
            this.Load += new System.EventHandler(this.PrestamosAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox P_CB;
        private System.Windows.Forms.TextBox Tipo_TB;
        private System.Windows.Forms.TextBox Salon_TB;
        private System.Windows.Forms.TextBox Persona_TB;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.MaskedTextBox H_MTB;
        private System.Windows.Forms.MaskedTextBox D_MTB;
    }
}