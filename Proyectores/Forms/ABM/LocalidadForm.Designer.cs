﻿namespace Proyectores.Forms.ABM {
    partial class LocalidadForm {
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
            this.Body = new System.Windows.Forms.Panel();
            this.BT_Ultimo = new System.Windows.Forms.Button();
            this.BT_Proximo = new System.Windows.Forms.Button();
            this.BT_Anterior = new System.Windows.Forms.Button();
            this.BT_Primero = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Body_GroupBox = new System.Windows.Forms.GroupBox();
            this.CB_Provincia = new System.Windows.Forms.ComboBox();
            this.provinciasEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.mTextBox_Edit2 = new Proyectores.Components.MTextBox_Edit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mTextBox_Edit1 = new Proyectores.Components.MTextBox_Edit();
            this.Body.SuspendLayout();
            this.Body_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.SystemColors.Control;
            this.Body.Controls.Add(this.BT_Ultimo);
            this.Body.Controls.Add(this.BT_Proximo);
            this.Body.Controls.Add(this.BT_Anterior);
            this.Body.Controls.Add(this.BT_Primero);
            this.Body.Controls.Add(this.BT_Cancel);
            this.Body.Controls.Add(this.BT_Save);
            this.Body.Controls.Add(this.Body_GroupBox);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(451, 271);
            this.Body.TabIndex = 0;
            // 
            // BT_Ultimo
            // 
            this.BT_Ultimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Ultimo.Location = new System.Drawing.Point(142, 233);
            this.BT_Ultimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Ultimo.Name = "BT_Ultimo";
            this.BT_Ultimo.Size = new System.Drawing.Size(36, 26);
            this.BT_Ultimo.TabIndex = 6;
            this.BT_Ultimo.Text = ">>";
            this.BT_Ultimo.UseVisualStyleBackColor = true;
            this.BT_Ultimo.Click += new System.EventHandler(this.BT_Ultimo_Click);
            // 
            // BT_Proximo
            // 
            this.BT_Proximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Proximo.Location = new System.Drawing.Point(100, 233);
            this.BT_Proximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Proximo.Name = "BT_Proximo";
            this.BT_Proximo.Size = new System.Drawing.Size(36, 26);
            this.BT_Proximo.TabIndex = 5;
            this.BT_Proximo.Text = ">";
            this.BT_Proximo.UseVisualStyleBackColor = true;
            this.BT_Proximo.Click += new System.EventHandler(this.BT_Proximo_Click);
            // 
            // BT_Anterior
            // 
            this.BT_Anterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Anterior.Location = new System.Drawing.Point(57, 233);
            this.BT_Anterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Anterior.Name = "BT_Anterior";
            this.BT_Anterior.Size = new System.Drawing.Size(36, 26);
            this.BT_Anterior.TabIndex = 4;
            this.BT_Anterior.Text = "<";
            this.BT_Anterior.UseVisualStyleBackColor = true;
            this.BT_Anterior.Click += new System.EventHandler(this.BT_Anterior_Click);
            // 
            // BT_Primero
            // 
            this.BT_Primero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Primero.Location = new System.Drawing.Point(14, 233);
            this.BT_Primero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Primero.Name = "BT_Primero";
            this.BT_Primero.Size = new System.Drawing.Size(36, 26);
            this.BT_Primero.TabIndex = 3;
            this.BT_Primero.Text = "<<";
            this.BT_Primero.UseVisualStyleBackColor = true;
            this.BT_Primero.Click += new System.EventHandler(this.BT_Primero_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancel.Location = new System.Drawing.Point(360, 233);
            this.BT_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(76, 26);
            this.BT_Cancel.TabIndex = 2;
            this.BT_Cancel.Text = "Cancelar";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save.Location = new System.Drawing.Point(280, 233);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(71, 26);
            this.BT_Save.TabIndex = 1;
            this.BT_Save.Text = "Guardar";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // Body_GroupBox
            // 
            this.Body_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body_GroupBox.Controls.Add(this.CB_Provincia);
            this.Body_GroupBox.Controls.Add(this.label3);
            this.Body_GroupBox.Controls.Add(this.mTextBox_Edit2);
            this.Body_GroupBox.Controls.Add(this.label2);
            this.Body_GroupBox.Controls.Add(this.label1);
            this.Body_GroupBox.Controls.Add(this.mTextBox_Edit1);
            this.Body_GroupBox.Location = new System.Drawing.Point(14, 13);
            this.Body_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Body_GroupBox.Name = "Body_GroupBox";
            this.Body_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Body_GroupBox.Size = new System.Drawing.Size(422, 205);
            this.Body_GroupBox.TabIndex = 0;
            this.Body_GroupBox.TabStop = false;
            this.Body_GroupBox.Text = "Alta Localidades";
            // 
            // CB_Provincia
            // 
            this.CB_Provincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_Provincia.DataSource = this.provinciasEntityBindingSource;
            this.CB_Provincia.DisplayMember = "Nombre";
            this.CB_Provincia.FormattingEnabled = true;
            this.CB_Provincia.Location = new System.Drawing.Point(170, 132);
            this.CB_Provincia.Name = "CB_Provincia";
            this.CB_Provincia.Size = new System.Drawing.Size(178, 24);
            this.CB_Provincia.TabIndex = 9;
            this.CB_Provincia.ValueMember = "ID";
            this.CB_Provincia.Enter += new System.EventHandler(this.CB_Provincia_Enter);
            // 
            // provinciasEntityBindingSource
            // 
            this.provinciasEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.ProvinciasEntity);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Provincia:";
            // 
            // mTextBox_Edit2
            // 
            this.mTextBox_Edit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mTextBox_Edit2.Location = new System.Drawing.Point(170, 96);
            this.mTextBox_Edit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mTextBox_Edit2.Name = "mTextBox_Edit2";
            this.mTextBox_Edit2.Size = new System.Drawing.Size(178, 22);
            this.mTextBox_Edit2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Postal:";
            // 
            // mTextBox_Edit1
            // 
            this.mTextBox_Edit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mTextBox_Edit1.Location = new System.Drawing.Point(170, 59);
            this.mTextBox_Edit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mTextBox_Edit1.Name = "mTextBox_Edit1";
            this.mTextBox_Edit1.Size = new System.Drawing.Size(79, 22);
            this.mTextBox_Edit1.TabIndex = 0;
            // 
            // LocalidadForm
            // 
            this.AcceptButton = this.BT_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BT_Cancel;
            this.ClientSize = new System.Drawing.Size(451, 271);
            this.ControlBox = false;
            this.Controls.Add(this.Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(453, 273);
            this.Name = "LocalidadForm";
            this.Text = "Localidad";
            this.Load += new System.EventHandler(this.LocalidadForm_Load);
            this.Body.ResumeLayout(false);
            this.Body_GroupBox.ResumeLayout(false);
            this.Body_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.GroupBox Body_GroupBox;
        private System.Windows.Forms.Button BT_Ultimo;
        private System.Windows.Forms.Button BT_Proximo;
        private System.Windows.Forms.Button BT_Anterior;
        private System.Windows.Forms.Button BT_Primero;
        private System.Windows.Forms.Label label1;
        private Proyectores.Components.MTextBox_Edit mTextBox_Edit1;
        private System.Windows.Forms.Label label3;
        private Proyectores.Components.MTextBox_Edit mTextBox_Edit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Provincia;
        private System.Windows.Forms.BindingSource provinciasEntityBindingSource;
    }
}