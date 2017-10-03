namespace Proyectores.Forms.ABM {
    partial class ProyectoresGrilla {
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
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.DelBT = new System.Windows.Forms.Button();
            this.EditBT = new System.Windows.Forms.Button();
            this.AgregarBT = new System.Windows.Forms.Button();
            this.Lb_Info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISPONIBLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDMIstrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISPONIBLEstrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATIVOstrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoresEntityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoresEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoresEntityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoresEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_TB
            // 
            this.Search_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_TB.Location = new System.Drawing.Point(988, 16);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(188, 26);
            this.Search_TB.TabIndex = 14;
            // 
            // DelBT
            // 
            this.DelBT.Image = global::Proyectores.Properties.Resources.trashcan;
            this.DelBT.Location = new System.Drawing.Point(280, 392);
            this.DelBT.Name = "DelBT";
            this.DelBT.Size = new System.Drawing.Size(128, 48);
            this.DelBT.TabIndex = 13;
            this.DelBT.Text = "Eliminar";
            this.DelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DelBT.UseVisualStyleBackColor = true;
            // 
            // EditBT
            // 
            this.EditBT.Image = global::Proyectores.Properties.Resources.pencil;
            this.EditBT.Location = new System.Drawing.Point(144, 392);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(128, 48);
            this.EditBT.TabIndex = 12;
            this.EditBT.Text = "Editar";
            this.EditBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditBT.UseVisualStyleBackColor = true;
            // 
            // AgregarBT
            // 
            this.AgregarBT.Image = global::Proyectores.Properties.Resources.sign_add;
            this.AgregarBT.Location = new System.Drawing.Point(8, 392);
            this.AgregarBT.Name = "AgregarBT";
            this.AgregarBT.Size = new System.Drawing.Size(128, 48);
            this.AgregarBT.TabIndex = 11;
            this.AgregarBT.Text = "Agregar";
            this.AgregarBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBT.UseVisualStyleBackColor = true;
            this.AgregarBT.Click += new System.EventHandler(this.AgregarBT_Click);
            // 
            // Lb_Info
            // 
            this.Lb_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Info.Location = new System.Drawing.Point(568, 384);
            this.Lb_Info.Name = "Lb_Info";
            this.Lb_Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lb_Info.Size = new System.Drawing.Size(605, 35);
            this.Lb_Info.TabIndex = 10;
            this.Lb_Info.Text = "<Entries>";
            this.Lb_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(904, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn,
            this.mODELODataGridViewTextBoxColumn,
            this.sERIALDataGridViewTextBoxColumn,
            this.hDMIDataGridViewTextBoxColumn,
            this.dISPONIBLEDataGridViewTextBoxColumn,
            this.oPERATIVODataGridViewTextBoxColumn,
            this.hDMIstrDataGridViewTextBoxColumn,
            this.dISPONIBLEstrDataGridViewTextBoxColumn,
            this.oPERATIVOstrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proyectoresEntityBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 317);
            this.dataGridView1.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            this.mARCADataGridViewTextBoxColumn.HeaderText = "Marca";
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            this.mARCADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mODELODataGridViewTextBoxColumn
            // 
            this.mODELODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mODELODataGridViewTextBoxColumn.DataPropertyName = "MODELO";
            this.mODELODataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.mODELODataGridViewTextBoxColumn.Name = "mODELODataGridViewTextBoxColumn";
            this.mODELODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sERIALDataGridViewTextBoxColumn
            // 
            this.sERIALDataGridViewTextBoxColumn.DataPropertyName = "SERIAL";
            this.sERIALDataGridViewTextBoxColumn.HeaderText = "N° Serie";
            this.sERIALDataGridViewTextBoxColumn.Name = "sERIALDataGridViewTextBoxColumn";
            this.sERIALDataGridViewTextBoxColumn.ReadOnly = true;
            this.sERIALDataGridViewTextBoxColumn.Width = 350;
            // 
            // hDMIDataGridViewTextBoxColumn
            // 
            this.hDMIDataGridViewTextBoxColumn.DataPropertyName = "HDMI";
            this.hDMIDataGridViewTextBoxColumn.HeaderText = "HDMI";
            this.hDMIDataGridViewTextBoxColumn.Name = "hDMIDataGridViewTextBoxColumn";
            this.hDMIDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDMIDataGridViewTextBoxColumn.Visible = false;
            // 
            // dISPONIBLEDataGridViewTextBoxColumn
            // 
            this.dISPONIBLEDataGridViewTextBoxColumn.DataPropertyName = "DISPONIBLE";
            this.dISPONIBLEDataGridViewTextBoxColumn.HeaderText = "DISPONIBLE";
            this.dISPONIBLEDataGridViewTextBoxColumn.Name = "dISPONIBLEDataGridViewTextBoxColumn";
            this.dISPONIBLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dISPONIBLEDataGridViewTextBoxColumn.Visible = false;
            // 
            // oPERATIVODataGridViewTextBoxColumn
            // 
            this.oPERATIVODataGridViewTextBoxColumn.DataPropertyName = "OPERATIVO";
            this.oPERATIVODataGridViewTextBoxColumn.HeaderText = "OPERATIVO";
            this.oPERATIVODataGridViewTextBoxColumn.Name = "oPERATIVODataGridViewTextBoxColumn";
            this.oPERATIVODataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERATIVODataGridViewTextBoxColumn.Visible = false;
            // 
            // hDMIstrDataGridViewTextBoxColumn
            // 
            this.hDMIstrDataGridViewTextBoxColumn.DataPropertyName = "HDMIstr";
            this.hDMIstrDataGridViewTextBoxColumn.HeaderText = "Tiene Hdmi?";
            this.hDMIstrDataGridViewTextBoxColumn.Name = "hDMIstrDataGridViewTextBoxColumn";
            this.hDMIstrDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDMIstrDataGridViewTextBoxColumn.Width = 140;
            // 
            // dISPONIBLEstrDataGridViewTextBoxColumn
            // 
            this.dISPONIBLEstrDataGridViewTextBoxColumn.DataPropertyName = "DISPONIBLEstr";
            this.dISPONIBLEstrDataGridViewTextBoxColumn.HeaderText = "Disponible";
            this.dISPONIBLEstrDataGridViewTextBoxColumn.Name = "dISPONIBLEstrDataGridViewTextBoxColumn";
            this.dISPONIBLEstrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oPERATIVOstrDataGridViewTextBoxColumn
            // 
            this.oPERATIVOstrDataGridViewTextBoxColumn.DataPropertyName = "OPERATIVOstr";
            this.oPERATIVOstrDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.oPERATIVOstrDataGridViewTextBoxColumn.Name = "oPERATIVOstrDataGridViewTextBoxColumn";
            this.oPERATIVOstrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proyectoresEntityBindingSource1
            // 
            this.proyectoresEntityBindingSource1.DataSource = typeof(Proyectores.Model.Entities.ProyectoresEntity);
            // 
            // proyectoresEntityBindingSource
            // 
            this.proyectoresEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.ProyectoresEntity);
            // 
            // ProyectoresGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 455);
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.DelBT);
            this.Controls.Add(this.EditBT);
            this.Controls.Add(this.AgregarBT);
            this.Controls.Add(this.Lb_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProyectoresGrilla";
            this.Text = "ProyectoresGrilla";
            this.Load += new System.EventHandler(this.ProyectoresGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoresEntityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoresEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_TB;
        private System.Windows.Forms.Button DelBT;
        private System.Windows.Forms.Button EditBT;
        private System.Windows.Forms.Button AgregarBT;
        private System.Windows.Forms.Label Lb_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource proyectoresEntityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISPONIBLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDMIstrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISPONIBLEstrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATIVOstrDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proyectoresEntityBindingSource1;
    }
}