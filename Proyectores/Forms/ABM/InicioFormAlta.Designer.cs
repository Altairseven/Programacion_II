namespace Proyectores.Forms.ABM {
    partial class InicioFormAlta {
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
            this.Body_GroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P_CB = new System.Windows.Forms.ComboBox();
            this.proyectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tipo_TB = new System.Windows.Forms.TextBox();
            this.Salon_TB = new System.Windows.Forms.TextBox();
            this.D_TB = new System.Windows.Forms.TextBox();
            this.H_TB = new System.Windows.Forms.TextBox();
            this.Persona_TB = new System.Windows.Forms.TextBox();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Body_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Body_GroupBox
            // 
            this.Body_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body_GroupBox.Controls.Add(this.label6);
            this.Body_GroupBox.Controls.Add(this.label5);
            this.Body_GroupBox.Controls.Add(this.label4);
            this.Body_GroupBox.Controls.Add(this.label3);
            this.Body_GroupBox.Controls.Add(this.label2);
            this.Body_GroupBox.Controls.Add(this.label1);
            this.Body_GroupBox.Controls.Add(this.P_CB);
            this.Body_GroupBox.Controls.Add(this.Tipo_TB);
            this.Body_GroupBox.Controls.Add(this.Salon_TB);
            this.Body_GroupBox.Controls.Add(this.D_TB);
            this.Body_GroupBox.Controls.Add(this.H_TB);
            this.Body_GroupBox.Controls.Add(this.Persona_TB);
            this.Body_GroupBox.Location = new System.Drawing.Point(16, 16);
            this.Body_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Body_GroupBox.Name = "Body_GroupBox";
            this.Body_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Body_GroupBox.Size = new System.Drawing.Size(481, 296);
            this.Body_GroupBox.TabIndex = 1;
            this.Body_GroupBox.TabStop = false;
            this.Body_GroupBox.Text = "Alta de Prestamo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Persona:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Proyectores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "A Cargo de:";
            // 
            // P_CB
            // 
            this.P_CB.DataSource = this.proyectoresBindingSource;
            this.P_CB.DisplayMember = "ID";
            this.P_CB.FormattingEnabled = true;
            this.P_CB.Location = new System.Drawing.Point(189, 205);
            this.P_CB.Name = "P_CB";
            this.P_CB.Size = new System.Drawing.Size(203, 28);
            this.P_CB.TabIndex = 5;
            this.P_CB.ValueMember = "ID";
            // 
            // proyectoresBindingSource
            // 
            this.proyectoresBindingSource.DataSource = typeof(Proyectores.Model.Proyectores);
            // 
            // Tipo_TB
            // 
            this.Tipo_TB.Enabled = false;
            this.Tipo_TB.Location = new System.Drawing.Point(189, 85);
            this.Tipo_TB.Name = "Tipo_TB";
            this.Tipo_TB.Size = new System.Drawing.Size(203, 26);
            this.Tipo_TB.TabIndex = 4;
            // 
            // Salon_TB
            // 
            this.Salon_TB.Enabled = false;
            this.Salon_TB.Location = new System.Drawing.Point(189, 165);
            this.Salon_TB.Name = "Salon_TB";
            this.Salon_TB.Size = new System.Drawing.Size(203, 26);
            this.Salon_TB.TabIndex = 3;
            // 
            // D_TB
            // 
            this.D_TB.Enabled = false;
            this.D_TB.Location = new System.Drawing.Point(189, 125);
            this.D_TB.Name = "D_TB";
            this.D_TB.Size = new System.Drawing.Size(64, 26);
            this.D_TB.TabIndex = 2;
            // 
            // H_TB
            // 
            this.H_TB.Enabled = false;
            this.H_TB.Location = new System.Drawing.Point(325, 125);
            this.H_TB.Name = "H_TB";
            this.H_TB.Size = new System.Drawing.Size(67, 26);
            this.H_TB.TabIndex = 1;
            // 
            // Persona_TB
            // 
            this.Persona_TB.Enabled = false;
            this.Persona_TB.Location = new System.Drawing.Point(189, 45);
            this.Persona_TB.Name = "Persona_TB";
            this.Persona_TB.Size = new System.Drawing.Size(203, 26);
            this.Persona_TB.TabIndex = 0;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancel.Location = new System.Drawing.Point(411, 320);
            this.BT_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(86, 32);
            this.BT_Cancel.TabIndex = 4;
            this.BT_Cancel.Text = "Cancelar";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save.Location = new System.Drawing.Point(307, 320);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(94, 32);
            this.BT_Save.TabIndex = 3;
            this.BT_Save.Text = "Confirmar";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // InicioFormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 364);
            this.ControlBox = false;
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.Body_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InicioFormAlta";
            this.Text = " Prestamo";
            this.Load += new System.EventHandler(this.PrestamosAlta_Load);
            this.Body_GroupBox.ResumeLayout(false);
            this.Body_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Body_GroupBox;
        
        
        private System.Windows.Forms.TextBox Tipo_TB;
        private System.Windows.Forms.TextBox Salon_TB;
        private System.Windows.Forms.TextBox D_TB;
        private System.Windows.Forms.TextBox H_TB;
        private System.Windows.Forms.TextBox Persona_TB;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.ComboBox P_CB;
        private System.Windows.Forms.BindingSource proyectoresBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}