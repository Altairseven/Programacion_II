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
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.Lb_Info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DelBT = new System.Windows.Forms.Button();
            this.EditBT = new System.Windows.Forms.Button();
            this.AgregarBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personasEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTOFULLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLOCALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEGAJODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_TB
            // 
            this.Search_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_TB.Location = new System.Drawing.Point(993, 10);
            this.Search_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(185, 26);
            this.Search_TB.TabIndex = 13;
            // 
            // Lb_Info
            // 
            this.Lb_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Info.Location = new System.Drawing.Point(576, 380);
            this.Lb_Info.Name = "Lb_Info";
            this.Lb_Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lb_Info.Size = new System.Drawing.Size(604, 30);
            this.Lb_Info.TabIndex = 9;
            this.Lb_Info.Text = "<Entries>";
            this.Lb_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(919, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar:";
            // 
            // DelBT
            // 
            this.DelBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelBT.Image = global::Proyectores.Properties.Resources.trashcan;
            this.DelBT.Location = new System.Drawing.Point(290, 380);
            this.DelBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelBT.Name = "DelBT";
            this.DelBT.Size = new System.Drawing.Size(128, 48);
            this.DelBT.TabIndex = 12;
            this.DelBT.Text = "Eliminar";
            this.DelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DelBT.UseVisualStyleBackColor = true;
            this.DelBT.Click += new System.EventHandler(this.DelBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditBT.Image = global::Proyectores.Properties.Resources.pencil;
            this.EditBT.Location = new System.Drawing.Point(154, 380);
            this.EditBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(128, 48);
            this.EditBT.TabIndex = 11;
            this.EditBT.Text = "Editar";
            this.EditBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditBT.UseVisualStyleBackColor = true;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // AgregarBT
            // 
            this.AgregarBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AgregarBT.Image = global::Proyectores.Properties.Resources.sign_add;
            this.AgregarBT.Location = new System.Drawing.Point(18, 380);
            this.AgregarBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarBT.Name = "AgregarBT";
            this.AgregarBT.Size = new System.Drawing.Size(128, 48);
            this.AgregarBT.TabIndex = 10;
            this.AgregarBT.Text = "Agregar";
            this.AgregarBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBT.UseVisualStyleBackColor = true;
            this.AgregarBT.Click += new System.EventHandler(this.AgregarBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tIPOPERSONADataGridViewTextBoxColumn,
            this.aPENOMDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.dOCUMENTOFULLDataGridViewTextBoxColumn,
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn,
            this.dOCUMENTODataGridViewTextBoxColumn,
            this.cUITDataGridViewTextBoxColumn,
            this.iDLOCALIDADDataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.locNombreDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.iDTIPOPERSONADataGridViewTextBoxColumn,
            this.lEGAJODataGridViewTextBoxColumn,
            this.docNombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personasEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 318);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // personasEntityBindingSource
            // 
            this.personasEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.PersonasEntity);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 70;
            // 
            // tIPOPERSONADataGridViewTextBoxColumn
            // 
            this.tIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PERSONA";
            this.tIPOPERSONADataGridViewTextBoxColumn.FillWeight = 456.8529F;
            this.tIPOPERSONADataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPOPERSONADataGridViewTextBoxColumn.MinimumWidth = 90;
            this.tIPOPERSONADataGridViewTextBoxColumn.Name = "tIPOPERSONADataGridViewTextBoxColumn";
            this.tIPOPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOPERSONADataGridViewTextBoxColumn.Width = 110;
            // 
            // aPENOMDataGridViewTextBoxColumn
            // 
            this.aPENOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aPENOMDataGridViewTextBoxColumn.DataPropertyName = "APE_NOM";
            this.aPENOMDataGridViewTextBoxColumn.FillWeight = 25.43083F;
            this.aPENOMDataGridViewTextBoxColumn.HeaderText = "Apellido y Nombre";
            this.aPENOMDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.aPENOMDataGridViewTextBoxColumn.Name = "aPENOMDataGridViewTextBoxColumn";
            this.aPENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBREDataGridViewTextBoxColumn.Visible = false;
            this.nOMBREDataGridViewTextBoxColumn.Width = 68;
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            this.aPELLIDODataGridViewTextBoxColumn.ReadOnly = true;
            this.aPELLIDODataGridViewTextBoxColumn.Visible = false;
            this.aPELLIDODataGridViewTextBoxColumn.Width = 68;
            // 
            // dOCUMENTOFULLDataGridViewTextBoxColumn
            // 
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO_FULL";
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.FillWeight = 265.1314F;
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.Name = "dOCUMENTOFULLDataGridViewTextBoxColumn";
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.Width = 160;
            // 
            // iDTIPODOCUMENTODataGridViewTextBoxColumn
            // 
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_DOCUMENTO";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.HeaderText = "ID_TIPO_DOCUMENTO";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.Name = "iDTIPODOCUMENTODataGridViewTextBoxColumn";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.Visible = false;
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.Width = 68;
            // 
            // dOCUMENTODataGridViewTextBoxColumn
            // 
            this.dOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO";
            this.dOCUMENTODataGridViewTextBoxColumn.HeaderText = "DOCUMENTO";
            this.dOCUMENTODataGridViewTextBoxColumn.Name = "dOCUMENTODataGridViewTextBoxColumn";
            this.dOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCUMENTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cUITDataGridViewTextBoxColumn
            // 
            this.cUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT";
            this.cUITDataGridViewTextBoxColumn.FillWeight = 25.43083F;
            this.cUITDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cUITDataGridViewTextBoxColumn.Name = "cUITDataGridViewTextBoxColumn";
            this.cUITDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUITDataGridViewTextBoxColumn.Width = 110;
            // 
            // iDLOCALIDADDataGridViewTextBoxColumn
            // 
            this.iDLOCALIDADDataGridViewTextBoxColumn.DataPropertyName = "ID_LOCALIDAD";
            this.iDLOCALIDADDataGridViewTextBoxColumn.HeaderText = "ID_LOCALIDAD";
            this.iDLOCALIDADDataGridViewTextBoxColumn.Name = "iDLOCALIDADDataGridViewTextBoxColumn";
            this.iDLOCALIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDLOCALIDADDataGridViewTextBoxColumn.Visible = false;
            this.iDLOCALIDADDataGridViewTextBoxColumn.Width = 68;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.FillWeight = 25.43083F;
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIRECCIONDataGridViewTextBoxColumn.Width = 150;
            // 
            // locNombreDataGridViewTextBoxColumn
            // 
            this.locNombreDataGridViewTextBoxColumn.DataPropertyName = "LocNombre";
            this.locNombreDataGridViewTextBoxColumn.FillWeight = 25.43083F;
            this.locNombreDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.locNombreDataGridViewTextBoxColumn.Name = "locNombreDataGridViewTextBoxColumn";
            this.locNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.locNombreDataGridViewTextBoxColumn.Width = 120;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.FillWeight = 25.43083F;
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEFONODataGridViewTextBoxColumn.Width = 120;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.FillWeight = 25.43083F;
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDTIPOPERSONADataGridViewTextBoxColumn
            // 
            this.iDTIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_PERSONA";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.HeaderText = "ID_TIPO_PERSONA";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.Name = "iDTIPOPERSONADataGridViewTextBoxColumn";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTIPOPERSONADataGridViewTextBoxColumn.Visible = false;
            this.iDTIPOPERSONADataGridViewTextBoxColumn.Width = 68;
            // 
            // lEGAJODataGridViewTextBoxColumn
            // 
            this.lEGAJODataGridViewTextBoxColumn.DataPropertyName = "LEGAJO";
            this.lEGAJODataGridViewTextBoxColumn.FillWeight = 25.43083F;
            this.lEGAJODataGridViewTextBoxColumn.HeaderText = "Legajo";
            this.lEGAJODataGridViewTextBoxColumn.Name = "lEGAJODataGridViewTextBoxColumn";
            this.lEGAJODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docNombreDataGridViewTextBoxColumn
            // 
            this.docNombreDataGridViewTextBoxColumn.DataPropertyName = "DocNombre";
            this.docNombreDataGridViewTextBoxColumn.HeaderText = "DocNombre";
            this.docNombreDataGridViewTextBoxColumn.Name = "docNombreDataGridViewTextBoxColumn";
            this.docNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.docNombreDataGridViewTextBoxColumn.Visible = false;
            this.docNombreDataGridViewTextBoxColumn.Width = 116;
            // 
            // PersonasGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 442);
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.DelBT);
            this.Controls.Add(this.EditBT);
            this.Controls.Add(this.AgregarBT);
            this.Controls.Add(this.Lb_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonasGrilla";
            this.Text = "PersonasGrilla";
            this.Load += new System.EventHandler(this.PersonasGrilla_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotKey_Listener);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasEntityBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource personasEntityBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTOFULLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLOCALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEGAJODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNombreDataGridViewTextBoxColumn;
    }
}