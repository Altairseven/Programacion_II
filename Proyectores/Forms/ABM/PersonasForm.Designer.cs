namespace Proyectores.Forms.ABM
{
    partial class PersonasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido_TB = new Proyectores.Components.MTextBox_Edit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_TB = new Proyectores.Components.MTextBox_Edit();
            this.BT_Ultimo = new System.Windows.Forms.Button();
            this.BT_Proximo = new System.Windows.Forms.Button();
            this.BT_Anterior = new System.Windows.Forms.Button();
            this.BT_Primero = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Body_GroupBox = new System.Windows.Forms.GroupBox();
            this.Cod_Postal_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Direccion_TB = new Proyectores.Components.MTextBox_Edit();
            this.Tipo_persona_CB = new System.Windows.Forms.ComboBox();
            this.tiposPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TipoDoc_CB = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.Documento_TB = new Proyectores.Components.MTextBox_Edit();
            this.legajo_TB = new Proyectores.Components.MTextBox_Edit();
            this.label10 = new System.Windows.Forms.Label();
            this.email_TB = new Proyectores.Components.MTextBox_Edit();
            this.label9 = new System.Windows.Forms.Label();
            this.telefono_TB = new Proyectores.Components.MTextBox_Edit();
            this.label8 = new System.Windows.Forms.Label();
            this.cuit_TB = new Proyectores.Components.MTextBox_Edit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Localidad_TB = new Proyectores.Components.MTextBox_Edit();
            this.tipoDocumentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Body_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // Apellido_TB
            // 
            this.Apellido_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Apellido_TB.Location = new System.Drawing.Point(492, 57);
            this.Apellido_TB.Name = "Apellido_TB";
            this.Apellido_TB.Size = new System.Drawing.Size(232, 26);
            this.Apellido_TB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento:";
            // 
            // Nombre_TB
            // 
            this.Nombre_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nombre_TB.Location = new System.Drawing.Point(123, 57);
            this.Nombre_TB.Name = "Nombre_TB";
            this.Nombre_TB.Size = new System.Drawing.Size(232, 26);
            this.Nombre_TB.TabIndex = 0;
            this.Nombre_TB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Nombre_TB_MaskInputRejected);
            // 
            // BT_Ultimo
            // 
            this.BT_Ultimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Ultimo.Location = new System.Drawing.Point(158, 337);
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
            this.BT_Proximo.Location = new System.Drawing.Point(110, 337);
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
            this.BT_Anterior.Location = new System.Drawing.Point(62, 337);
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
            this.BT_Primero.Location = new System.Drawing.Point(15, 337);
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
            this.BT_Cancel.Location = new System.Drawing.Point(678, 337);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(80, 32);
            this.BT_Cancel.TabIndex = 9;
            this.BT_Cancel.Text = "Cancelar";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save.Location = new System.Drawing.Point(580, 337);
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
            this.Body_GroupBox.Controls.Add(this.Cod_Postal_TB);
            this.Body_GroupBox.Controls.Add(this.label4);
            this.Body_GroupBox.Controls.Add(this.Direccion_TB);
            this.Body_GroupBox.Controls.Add(this.Tipo_persona_CB);
            this.Body_GroupBox.Controls.Add(this.TipoDoc_CB);
            this.Body_GroupBox.Controls.Add(this.label11);
            this.Body_GroupBox.Controls.Add(this.Documento_TB);
            this.Body_GroupBox.Controls.Add(this.legajo_TB);
            this.Body_GroupBox.Controls.Add(this.label10);
            this.Body_GroupBox.Controls.Add(this.email_TB);
            this.Body_GroupBox.Controls.Add(this.label9);
            this.Body_GroupBox.Controls.Add(this.telefono_TB);
            this.Body_GroupBox.Controls.Add(this.label8);
            this.Body_GroupBox.Controls.Add(this.cuit_TB);
            this.Body_GroupBox.Controls.Add(this.label7);
            this.Body_GroupBox.Controls.Add(this.label6);
            this.Body_GroupBox.Controls.Add(this.Localidad_TB);
            this.Body_GroupBox.Controls.Add(this.label3);
            this.Body_GroupBox.Controls.Add(this.Apellido_TB);
            this.Body_GroupBox.Controls.Add(this.label2);
            this.Body_GroupBox.Controls.Add(this.label1);
            this.Body_GroupBox.Controls.Add(this.Nombre_TB);
            this.Body_GroupBox.Location = new System.Drawing.Point(15, 17);
            this.Body_GroupBox.Name = "Body_GroupBox";
            this.Body_GroupBox.Size = new System.Drawing.Size(744, 297);
            this.Body_GroupBox.TabIndex = 7;
            this.Body_GroupBox.TabStop = false;
            this.Body_GroupBox.Text = "Alta Personas";
            this.Body_GroupBox.Enter += new System.EventHandler(this.Body_GroupBox_Enter);
            // 
            // Cod_Postal_TB
            // 
            this.Cod_Postal_TB.Location = new System.Drawing.Point(492, 102);
            this.Cod_Postal_TB.Name = "Cod_Postal_TB";
            this.Cod_Postal_TB.Size = new System.Drawing.Size(72, 26);
            this.Cod_Postal_TB.TabIndex = 7;
            this.Cod_Postal_TB.DoubleClick += new System.EventHandler(this.CodPostal_DbCLick);
            this.Cod_Postal_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cod_Postal_TB_KeyDown);
            this.Cod_Postal_TB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cod_Postal_TB_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Direccion:";
            // 
            // Direccion_TB
            // 
            this.Direccion_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Direccion_TB.Location = new System.Drawing.Point(492, 145);
            this.Direccion_TB.Name = "Direccion_TB";
            this.Direccion_TB.Size = new System.Drawing.Size(232, 26);
            this.Direccion_TB.TabIndex = 8;
            // 
            // Tipo_persona_CB
            // 
            this.Tipo_persona_CB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tipo_persona_CB.DataSource = this.tiposPersonaBindingSource;
            this.Tipo_persona_CB.DisplayMember = "NOMBRE";
            this.Tipo_persona_CB.FormattingEnabled = true;
            this.Tipo_persona_CB.Location = new System.Drawing.Point(123, 185);
            this.Tipo_persona_CB.Name = "Tipo_persona_CB";
            this.Tipo_persona_CB.Size = new System.Drawing.Size(232, 28);
            this.Tipo_persona_CB.TabIndex = 5;
            this.Tipo_persona_CB.ValueMember = "ID";
            // 
            // tiposPersonaBindingSource
            // 
            this.tiposPersonaBindingSource.DataSource = typeof(Model.Tipos_Persona);
            // 
            // TipoDoc_CB
            // 
            this.TipoDoc_CB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TipoDoc_CB.DataSource = this.tipoDocumentoBindingSource;
            this.TipoDoc_CB.DisplayMember = "NOMBRE";
            this.TipoDoc_CB.FormattingEnabled = true;
            this.TipoDoc_CB.Location = new System.Drawing.Point(123, 101);
            this.TipoDoc_CB.Name = "TipoDoc_CB";
            this.TipoDoc_CB.Size = new System.Drawing.Size(72, 28);
            this.TipoDoc_CB.TabIndex = 2;
            this.TipoDoc_CB.ValueMember = "ID";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataSource = typeof(Model.Tipo_Documento);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tipo:";
            // 
            // Documento_TB
            // 
            this.Documento_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Documento_TB.Location = new System.Drawing.Point(204, 102);
            this.Documento_TB.Name = "Documento_TB";
            this.Documento_TB.Size = new System.Drawing.Size(152, 26);
            this.Documento_TB.TabIndex = 3;
            // 
            // legajo_TB
            // 
            this.legajo_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legajo_TB.Location = new System.Drawing.Point(123, 225);
            this.legajo_TB.Name = "legajo_TB";
            this.legajo_TB.Size = new System.Drawing.Size(232, 26);
            this.legajo_TB.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Legajo:";
            // 
            // email_TB
            // 
            this.email_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_TB.Location = new System.Drawing.Point(492, 225);
            this.email_TB.Name = "email_TB";
            this.email_TB.Size = new System.Drawing.Size(232, 26);
            this.email_TB.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email:";
            // 
            // telefono_TB
            // 
            this.telefono_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefono_TB.Location = new System.Drawing.Point(492, 188);
            this.telefono_TB.Name = "telefono_TB";
            this.telefono_TB.Size = new System.Drawing.Size(232, 26);
            this.telefono_TB.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefono:";
            // 
            // cuit_TB
            // 
            this.cuit_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuit_TB.Location = new System.Drawing.Point(123, 145);
            this.cuit_TB.Name = "cuit_TB";
            this.cuit_TB.Size = new System.Drawing.Size(232, 26);
            this.cuit_TB.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "CUIT:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Localidad:";
            // 
            // Localidad_TB
            // 
            this.Localidad_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Localidad_TB.Enabled = false;
            this.Localidad_TB.Location = new System.Drawing.Point(572, 102);
            this.Localidad_TB.Name = "Localidad_TB";
            this.Localidad_TB.Size = new System.Drawing.Size(152, 26);
            this.Localidad_TB.TabIndex = 9;
            // 
            // tipoDocumentoBindingSource1
            // 
            this.tipoDocumentoBindingSource1.DataSource = typeof(Model.Tipo_Documento);
            // 
            // PersonasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 402);
            this.Controls.Add(this.BT_Ultimo);
            this.Controls.Add(this.BT_Proximo);
            this.Controls.Add(this.BT_Anterior);
            this.Controls.Add(this.BT_Primero);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.Body_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(790, 431);
            this.Name = "PersonasForm";
            this.Load += new System.EventHandler(this.PersonasForm_Load);
            this.Body_GroupBox.ResumeLayout(false);
            this.Body_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Components.MTextBox_Edit Apellido_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Components.MTextBox_Edit Nombre_TB;
        private System.Windows.Forms.Button BT_Ultimo;
        private System.Windows.Forms.Button BT_Proximo;
        private System.Windows.Forms.Button BT_Anterior;
        private System.Windows.Forms.Button BT_Primero;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.GroupBox Body_GroupBox;
        private System.Windows.Forms.Label label6;
        private Components.MTextBox_Edit Localidad_TB;
        private Components.MTextBox_Edit cuit_TB;
        private System.Windows.Forms.Label label7;
        private Components.MTextBox_Edit telefono_TB;
        private System.Windows.Forms.Label label8;
        private Components.MTextBox_Edit legajo_TB;
        private System.Windows.Forms.Label label10;
        private Components.MTextBox_Edit email_TB;
        private System.Windows.Forms.Label label9;
        private Components.MTextBox_Edit Documento_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private Components.MTextBox_Edit Direccion_TB;
        private System.Windows.Forms.ComboBox Tipo_persona_CB;
        private System.Windows.Forms.BindingSource tiposPersonaBindingSource;
        private System.Windows.Forms.ComboBox TipoDoc_CB;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource1;
        private System.Windows.Forms.TextBox Cod_Postal_TB;
    }
}