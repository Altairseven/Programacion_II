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
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido = new Proyectores.Components.MTextBox_Edit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new Proyectores.Components.MTextBox_Edit();
            this.BT_Ultimo = new System.Windows.Forms.Button();
            this.BT_Proximo = new System.Windows.Forms.Button();
            this.BT_Anterior = new System.Windows.Forms.Button();
            this.BT_Primero = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Body_GroupBox = new System.Windows.Forms.GroupBox();
            this.telefono = new Proyectores.Components.MTextBox_Edit();
            this.label8 = new System.Windows.Forms.Label();
            this.cuit = new Proyectores.Components.MTextBox_Edit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Localidad = new Proyectores.Components.MTextBox_Edit();
            this.label9 = new System.Windows.Forms.Label();
            this.email = new Proyectores.Components.MTextBox_Edit();
            this.label10 = new System.Windows.Forms.Label();
            this.legajo = new Proyectores.Components.MTextBox_Edit();
            this.Documento = new Proyectores.Components.MTextBox_Edit();
            this.id_tipo_persona = new Proyectores.Components.DB_ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.codigo_postal = new Proyectores.Components.MTextBox_Edit();
            this.dB_ComboBox1 = new Proyectores.Components.DB_ComboBox();
            this.mTextBox_Edit1 = new Proyectores.Components.MTextBox_Edit();
            this.Body_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Apellido
            // 
            this.Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Apellido.Location = new System.Drawing.Point(309, 30);
            this.Apellido.Margin = new System.Windows.Forms.Padding(2);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(135, 20);
            this.Apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento:";
            // 
            // Nombre
            // 
            this.Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nombre.Location = new System.Drawing.Point(90, 30);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(150, 20);
            this.Nombre.TabIndex = 0;
            // 
            // BT_Ultimo
            // 
            this.BT_Ultimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Ultimo.Location = new System.Drawing.Point(127, 441);
            this.BT_Ultimo.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Ultimo.Name = "BT_Ultimo";
            this.BT_Ultimo.Size = new System.Drawing.Size(27, 21);
            this.BT_Ultimo.TabIndex = 13;
            this.BT_Ultimo.Text = ">>";
            this.BT_Ultimo.UseVisualStyleBackColor = true;
            // 
            // BT_Proximo
            // 
            this.BT_Proximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Proximo.Location = new System.Drawing.Point(94, 441);
            this.BT_Proximo.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Proximo.Name = "BT_Proximo";
            this.BT_Proximo.Size = new System.Drawing.Size(27, 21);
            this.BT_Proximo.TabIndex = 12;
            this.BT_Proximo.Text = ">";
            this.BT_Proximo.UseVisualStyleBackColor = true;
            // 
            // BT_Anterior
            // 
            this.BT_Anterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Anterior.Location = new System.Drawing.Point(63, 441);
            this.BT_Anterior.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Anterior.Name = "BT_Anterior";
            this.BT_Anterior.Size = new System.Drawing.Size(27, 21);
            this.BT_Anterior.TabIndex = 11;
            this.BT_Anterior.Text = "<";
            this.BT_Anterior.UseVisualStyleBackColor = true;
            // 
            // BT_Primero
            // 
            this.BT_Primero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Primero.Location = new System.Drawing.Point(32, 441);
            this.BT_Primero.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Primero.Name = "BT_Primero";
            this.BT_Primero.Size = new System.Drawing.Size(27, 21);
            this.BT_Primero.TabIndex = 10;
            this.BT_Primero.Text = "<<";
            this.BT_Primero.UseVisualStyleBackColor = true;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancel.Location = new System.Drawing.Point(481, 441);
            this.BT_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(53, 21);
            this.BT_Cancel.TabIndex = 9;
            this.BT_Cancel.Text = "Cancelar";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save.Location = new System.Drawing.Point(406, 441);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(53, 21);
            this.BT_Save.TabIndex = 8;
            this.BT_Save.Text = "Guardar";
            this.BT_Save.UseVisualStyleBackColor = true;
            // 
            // Body_GroupBox
            // 
            this.Body_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body_GroupBox.Controls.Add(this.mTextBox_Edit1);
            this.Body_GroupBox.Controls.Add(this.dB_ComboBox1);
            this.Body_GroupBox.Controls.Add(this.codigo_postal);
            this.Body_GroupBox.Controls.Add(this.label11);
            this.Body_GroupBox.Controls.Add(this.id_tipo_persona);
            this.Body_GroupBox.Controls.Add(this.Documento);
            this.Body_GroupBox.Controls.Add(this.legajo);
            this.Body_GroupBox.Controls.Add(this.label10);
            this.Body_GroupBox.Controls.Add(this.email);
            this.Body_GroupBox.Controls.Add(this.label9);
            this.Body_GroupBox.Controls.Add(this.telefono);
            this.Body_GroupBox.Controls.Add(this.label8);
            this.Body_GroupBox.Controls.Add(this.cuit);
            this.Body_GroupBox.Controls.Add(this.label7);
            this.Body_GroupBox.Controls.Add(this.label6);
            this.Body_GroupBox.Controls.Add(this.Localidad);
            this.Body_GroupBox.Controls.Add(this.label3);
            this.Body_GroupBox.Controls.Add(this.Apellido);
            this.Body_GroupBox.Controls.Add(this.label2);
            this.Body_GroupBox.Controls.Add(this.label1);
            this.Body_GroupBox.Controls.Add(this.Nombre);
            this.Body_GroupBox.Location = new System.Drawing.Point(11, 11);
            this.Body_GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.Body_GroupBox.Name = "Body_GroupBox";
            this.Body_GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Body_GroupBox.Size = new System.Drawing.Size(448, 394);
            this.Body_GroupBox.TabIndex = 7;
            this.Body_GroupBox.TabStop = false;
            this.Body_GroupBox.Text = "Alta Personas";
            // 
            // telefono
            // 
            this.telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefono.Location = new System.Drawing.Point(309, 60);
            this.telefono.Margin = new System.Windows.Forms.Padding(2);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(135, 20);
            this.telefono.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefono:";
            // 
            // cuit
            // 
            this.cuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuit.Location = new System.Drawing.Point(90, 145);
            this.cuit.Margin = new System.Windows.Forms.Padding(2);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(150, 20);
            this.cuit.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "CUIT:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Localidad:";
            // 
            // Localidad
            // 
            this.Localidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Localidad.Enabled = false;
            this.Localidad.Location = new System.Drawing.Point(142, 89);
            this.Localidad.Margin = new System.Windows.Forms.Padding(2);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(98, 20);
            this.Localidad.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email:";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.Location = new System.Drawing.Point(309, 83);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(135, 20);
            this.email.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Legajo:";
            // 
            // legajo
            // 
            this.legajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legajo.Location = new System.Drawing.Point(309, 105);
            this.legajo.Margin = new System.Windows.Forms.Padding(2);
            this.legajo.Name = "legajo";
            this.legajo.Size = new System.Drawing.Size(135, 20);
            this.legajo.TabIndex = 22;
            // 
            // Documento
            // 
            this.Documento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Documento.Location = new System.Drawing.Point(141, 59);
            this.Documento.Margin = new System.Windows.Forms.Padding(2);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(99, 20);
            this.Documento.TabIndex = 23;
            // 
            // id_tipo_persona
            // 
            this.id_tipo_persona.DBItemList = null;
            this.id_tipo_persona.FormattingEnabled = true;
            this.id_tipo_persona.Location = new System.Drawing.Point(309, 130);
            this.id_tipo_persona.Name = "id_tipo_persona";
            this.id_tipo_persona.SelectedID = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.id_tipo_persona.Size = new System.Drawing.Size(134, 21);
            this.id_tipo_persona.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "ID_tipo_persona:";
            // 
            // codigo_postal
            // 
            this.codigo_postal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codigo_postal.Location = new System.Drawing.Point(92, 89);
            this.codigo_postal.Margin = new System.Windows.Forms.Padding(2);
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.Size = new System.Drawing.Size(46, 20);
            this.codigo_postal.TabIndex = 26;
            this.codigo_postal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigo_postal_MaskInputRejected);
            // 
            // dB_ComboBox1
            // 
            this.dB_ComboBox1.DBItemList = null;
            this.dB_ComboBox1.FormattingEnabled = true;
            this.dB_ComboBox1.Location = new System.Drawing.Point(90, 59);
            this.dB_ComboBox1.Name = "dB_ComboBox1";
            this.dB_ComboBox1.SelectedID = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dB_ComboBox1.Size = new System.Drawing.Size(44, 21);
            this.dB_ComboBox1.TabIndex = 27;
            // 
            // mTextBox_Edit1
            // 
            this.mTextBox_Edit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mTextBox_Edit1.Location = new System.Drawing.Point(92, 117);
            this.mTextBox_Edit1.Margin = new System.Windows.Forms.Padding(2);
            this.mTextBox_Edit1.Name = "mTextBox_Edit1";
            this.mTextBox_Edit1.Size = new System.Drawing.Size(148, 20);
            this.mTextBox_Edit1.TabIndex = 28;
            // 
            // PersonasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 496);
            this.Controls.Add(this.BT_Ultimo);
            this.Controls.Add(this.BT_Proximo);
            this.Controls.Add(this.BT_Anterior);
            this.Controls.Add(this.BT_Primero);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.Body_GroupBox);
            this.Name = "PersonasForm";
            this.Text = "PersonasForm";
            this.Body_GroupBox.ResumeLayout(false);
            this.Body_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Components.MTextBox_Edit Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Components.MTextBox_Edit Nombre;
        private System.Windows.Forms.Button BT_Ultimo;
        private System.Windows.Forms.Button BT_Proximo;
        private System.Windows.Forms.Button BT_Anterior;
        private System.Windows.Forms.Button BT_Primero;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.GroupBox Body_GroupBox;
        private System.Windows.Forms.Label label6;
        private Components.MTextBox_Edit Localidad;
        private Components.MTextBox_Edit cuit;
        private System.Windows.Forms.Label label7;
        private Components.MTextBox_Edit telefono;
        private System.Windows.Forms.Label label8;
        private Components.MTextBox_Edit legajo;
        private System.Windows.Forms.Label label10;
        private Components.MTextBox_Edit email;
        private System.Windows.Forms.Label label9;
        private Components.DB_ComboBox id_tipo_persona;
        private Components.MTextBox_Edit Documento;
        private Components.MTextBox_Edit codigo_postal;
        private System.Windows.Forms.Label label11;
        private Components.DB_ComboBox dB_ComboBox1;
        private Components.MTextBox_Edit mTextBox_Edit1;
    }
}