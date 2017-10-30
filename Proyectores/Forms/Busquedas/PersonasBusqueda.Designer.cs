namespace Proyectores.Forms.Busquedas {
    partial class PersonasBusqueda {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLOCALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEGAJODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTOFULLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personasEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn,
            this.dOCUMENTODataGridViewTextBoxColumn,
            this.cUITDataGridViewTextBoxColumn,
            this.iDLOCALIDADDataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.iDTIPOPERSONADataGridViewTextBoxColumn,
            this.locNombreDataGridViewTextBoxColumn,
            this.docNombreDataGridViewTextBoxColumn,
            this.tIPOPERSONADataGridViewTextBoxColumn,
            this.aPENOMDataGridViewTextBoxColumn,
            this.lEGAJODataGridViewTextBoxColumn,
            this.dOCUMENTOFULLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personasEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 270);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnGrid_KeyDown);
            // 
            // Search_TB
            // 
            this.Search_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_TB.Location = new System.Drawing.Point(18, 20);
            this.Search_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(270, 26);
            this.Search_TB.TabIndex = 1;
            this.Search_TB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_Tb_KeyUp);
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
            this.nOMBREDataGridViewTextBoxColumn.Visible = false;
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            this.aPELLIDODataGridViewTextBoxColumn.ReadOnly = true;
            this.aPELLIDODataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTIPODOCUMENTODataGridViewTextBoxColumn
            // 
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_DOCUMENTO";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.HeaderText = "ID_TIPO_DOCUMENTO";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.Name = "iDTIPODOCUMENTODataGridViewTextBoxColumn";
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTIPODOCUMENTODataGridViewTextBoxColumn.Visible = false;
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
            this.cUITDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cUITDataGridViewTextBoxColumn.Name = "cUITDataGridViewTextBoxColumn";
            this.cUITDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUITDataGridViewTextBoxColumn.Visible = false;
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
            this.dIRECCIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEFONODataGridViewTextBoxColumn.Visible = false;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTIPOPERSONADataGridViewTextBoxColumn
            // 
            this.iDTIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_PERSONA";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.HeaderText = "ID_TIPO_PERSONA";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.Name = "iDTIPOPERSONADataGridViewTextBoxColumn";
            this.iDTIPOPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTIPOPERSONADataGridViewTextBoxColumn.Visible = false;
            // 
            // locNombreDataGridViewTextBoxColumn
            // 
            this.locNombreDataGridViewTextBoxColumn.DataPropertyName = "LocNombre";
            this.locNombreDataGridViewTextBoxColumn.HeaderText = "LocNombre";
            this.locNombreDataGridViewTextBoxColumn.Name = "locNombreDataGridViewTextBoxColumn";
            this.locNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.locNombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // docNombreDataGridViewTextBoxColumn
            // 
            this.docNombreDataGridViewTextBoxColumn.DataPropertyName = "DocNombre";
            this.docNombreDataGridViewTextBoxColumn.HeaderText = "DocNombre";
            this.docNombreDataGridViewTextBoxColumn.Name = "docNombreDataGridViewTextBoxColumn";
            this.docNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.docNombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPOPERSONADataGridViewTextBoxColumn
            // 
            this.tIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PERSONA";
            this.tIPOPERSONADataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPOPERSONADataGridViewTextBoxColumn.Name = "tIPOPERSONADataGridViewTextBoxColumn";
            this.tIPOPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOPERSONADataGridViewTextBoxColumn.Width = 120;
            // 
            // aPENOMDataGridViewTextBoxColumn
            // 
            this.aPENOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aPENOMDataGridViewTextBoxColumn.DataPropertyName = "APE_NOM";
            this.aPENOMDataGridViewTextBoxColumn.HeaderText = "Apellido, Nombre";
            this.aPENOMDataGridViewTextBoxColumn.Name = "aPENOMDataGridViewTextBoxColumn";
            this.aPENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lEGAJODataGridViewTextBoxColumn
            // 
            this.lEGAJODataGridViewTextBoxColumn.DataPropertyName = "LEGAJO";
            this.lEGAJODataGridViewTextBoxColumn.HeaderText = "Legajo";
            this.lEGAJODataGridViewTextBoxColumn.Name = "lEGAJODataGridViewTextBoxColumn";
            this.lEGAJODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCUMENTOFULLDataGridViewTextBoxColumn
            // 
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO_FULL";
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.Name = "dOCUMENTOFULLDataGridViewTextBoxColumn";
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCUMENTOFULLDataGridViewTextBoxColumn.Width = 200;
            // 
            // personasEntityBindingSource
            // 
            this.personasEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.PersonasEntity);
            // 
            // PersonasBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 346);
            this.ControlBox = false;
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonasBusqueda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.LocalidadesBusqueda_Load);
            this.Shown += new System.EventHandler(this.PersonasBusqueda_Shown);
            this.Enter += new System.EventHandler(this.PersonasBusqueda_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPODOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLOCALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEGAJODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTOFULLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personasEntityBindingSource;
    }
}