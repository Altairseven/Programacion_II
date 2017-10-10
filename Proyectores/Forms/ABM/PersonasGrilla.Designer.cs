namespace Proyectores.Forms.ABM
{
    partial class PersonasGrilla
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLOCALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEGAJODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personasEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.Lb_Info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DelBT = new System.Windows.Forms.Button();
            this.EditBT = new System.Windows.Forms.Button();
            this.AgregarBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasEntityBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn,
            this.docNombreDataGridViewTextBoxColumn,
            this.dOCUMENTODataGridViewTextBoxColumn,
            this.cUITDataGridViewTextBoxColumn,
            this.iDLOCALIDADDataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.iDTIPOPERSONADataGridViewTextBoxColumn,
            this.lEGAJODataGridViewTextBoxColumn,
            this.locNombreDataGridViewTextBoxColumn,
            this.tIPOPERSONADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personasEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1282, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            this.aPELLIDODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTIPODOCUMENTODataGridViewTextBoxColumn
            // 
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_DOCUMENTO";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.HeaderText = "ID_TIPO_DOCUMENTO";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.Name = "iDTIPODOCUMENTODataGridViewTextBoxColumn";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // docNombreDataGridViewTextBoxColumn
            // 
            this.docNombreDataGridViewTextBoxColumn.DataPropertyName = "DocNombre";
            this.docNombreDataGridViewTextBoxColumn.HeaderText = "DocNombre";
            this.docNombreDataGridViewTextBoxColumn.Name = "docNombreDataGridViewTextBoxColumn";
            this.docNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCUMENTODataGridViewTextBoxColumn
            // 
            this.dOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO";
            this.dOCUMENTODataGridViewTextBoxColumn.HeaderText = "DOCUMENTO";
            this.dOCUMENTODataGridViewTextBoxColumn.Name = "dOCUMENTODataGridViewTextBoxColumn";
            this.dOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUITDataGridViewTextBoxColumn
            // 
            this.cUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT";
            this.cUITDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cUITDataGridViewTextBoxColumn.Name = "cUITDataGridViewTextBoxColumn";
            this.cUITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDLOCALIDADDataGridViewTextBoxColumn
            // 
            this.iDLOCALIDADDataGridViewTextBoxColumn.DataPropertyName = "ID_LOCALIDAD";
            this.iDLOCALIDADDataGridViewTextBoxColumn.HeaderText = "ID_LOCALIDAD";
            this.iDLOCALIDADDataGridViewTextBoxColumn.Name = "iDLOCALIDADDataGridViewTextBoxColumn";
            this.iDLOCALIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDLOCALIDADDataGridViewTextBoxColumn.Visible = false;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTIPOPERSONADataGridViewTextBoxColumn
            // 
            this.iDTIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_PERSONA";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.HeaderText = "ID_TIPO_PERSONA";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.Name = "iDTIPOPERSONADataGridViewTextBoxColumn";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTIPOPERSONADataGridViewTextBoxColumn.Visible = false;
            // 
            // lEGAJODataGridViewTextBoxColumn
            // 
            this.lEGAJODataGridViewTextBoxColumn.DataPropertyName = "LEGAJO";
            this.lEGAJODataGridViewTextBoxColumn.HeaderText = "LEGAJO";
            this.lEGAJODataGridViewTextBoxColumn.Name = "lEGAJODataGridViewTextBoxColumn";
            this.lEGAJODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locNombreDataGridViewTextBoxColumn
            // 
            this.locNombreDataGridViewTextBoxColumn.DataPropertyName = "LocNombre";
            this.locNombreDataGridViewTextBoxColumn.HeaderText = "LocNombre";
            this.locNombreDataGridViewTextBoxColumn.Name = "locNombreDataGridViewTextBoxColumn";
            this.locNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOPERSONADataGridViewTextBoxColumn
            // 
            this.tIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PERSONA";
            this.tIPOPERSONADataGridViewTextBoxColumn.HeaderText = "TIPO_PERSONA";
            this.tIPOPERSONADataGridViewTextBoxColumn.Name = "tIPOPERSONADataGridViewTextBoxColumn";
            this.tIPOPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personasEntityBindingSource
            // 
            this.personasEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.PersonasEntity);
            // 
            // Search_TB
            // 
            this.Search_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_TB.Location = new System.Drawing.Point(1128, 16);
            this.Search_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(168, 22);
            this.Search_TB.TabIndex = 13;
            // 
            // Lb_Info
            // 
            this.Lb_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Info.Location = new System.Drawing.Point(760, 304);
            this.Lb_Info.Name = "Lb_Info";
            this.Lb_Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lb_Info.Size = new System.Drawing.Size(537, 24);
            this.Lb_Info.TabIndex = 9;
            this.Lb_Info.Text = "<Entries>";
            this.Lb_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar:";
            // 
            // DelBT
            // 
            this.DelBT.Image = global::Proyectores.Properties.Resources.trashcan;
            this.DelBT.Location = new System.Drawing.Point(254, 304);
            this.DelBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelBT.Name = "DelBT";
            this.DelBT.Size = new System.Drawing.Size(114, 38);
            this.DelBT.TabIndex = 12;
            this.DelBT.Text = "Eliminar";
            this.DelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DelBT.UseVisualStyleBackColor = true;
            // 
            // EditBT
            // 
            this.EditBT.Image = global::Proyectores.Properties.Resources.pencil;
            this.EditBT.Location = new System.Drawing.Point(135, 304);
            this.EditBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(114, 38);
            this.EditBT.TabIndex = 11;
            this.EditBT.Text = "Editar";
            this.EditBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditBT.UseVisualStyleBackColor = true;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // AgregarBT
            // 
            this.AgregarBT.Image = global::Proyectores.Properties.Resources.sign_add;
            this.AgregarBT.Location = new System.Drawing.Point(16, 304);
            this.AgregarBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarBT.Name = "AgregarBT";
            this.AgregarBT.Size = new System.Drawing.Size(114, 38);
            this.AgregarBT.TabIndex = 10;
            this.AgregarBT.Text = "Agregar";
            this.AgregarBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBT.UseVisualStyleBackColor = true;
            this.AgregarBT.Click += new System.EventHandler(this.AgregarBT_Click);
            // 
            // PersonasGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 355);
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.DelBT);
            this.Controls.Add(this.EditBT);
            this.Controls.Add(this.AgregarBT);
            this.Controls.Add(this.Lb_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonasGrilla";
            this.Text = "PersonasGrilla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_TB;
        private System.Windows.Forms.Button DelBT;
        private System.Windows.Forms.Button EditBT;
        private System.Windows.Forms.Button AgregarBT;
        private System.Windows.Forms.Label Lb_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLOCALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEGAJODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personasEntityBindingSource;
    }
}