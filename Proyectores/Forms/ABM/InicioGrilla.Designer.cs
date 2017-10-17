namespace Proyectores.Forms.ABM {
    partial class InicioGrilla {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.prestamosEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPROYECTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSALONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRESERVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDESDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hHASTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desdeSrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDPROYECTORDataGridViewTextBoxColumn,
            this.iDSALONDataGridViewTextBoxColumn,
            this.iDPERSONADataGridViewTextBoxColumn,
            this.iDRESERVADataGridViewTextBoxColumn,
            this.hDESDEDataGridViewTextBoxColumn,
            this.hHASTADataGridViewTextBoxColumn,
            this.aCTIVODataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.desdeSrtDataGridViewTextBoxColumn,
            this.hastaSrtDataGridViewTextBoxColumn,
            this.sALONDataGridViewTextBoxColumn,
            this.aPENOMDataGridViewTextBoxColumn,
            this.tIPOPERSONADataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.test});
            this.dataGridView1.DataSource = this.prestamosEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1262, 368);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 56);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 8);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(4, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(1152, 40);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1216, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // prestamosEntityBindingSource
            // 
            this.prestamosEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.PrestamosEntity);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPROYECTORDataGridViewTextBoxColumn
            // 
            this.iDPROYECTORDataGridViewTextBoxColumn.DataPropertyName = "ID_PROYECTOR";
            this.iDPROYECTORDataGridViewTextBoxColumn.HeaderText = "ID_PROYECTOR";
            this.iDPROYECTORDataGridViewTextBoxColumn.Name = "iDPROYECTORDataGridViewTextBoxColumn";
            this.iDPROYECTORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPROYECTORDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSALONDataGridViewTextBoxColumn
            // 
            this.iDSALONDataGridViewTextBoxColumn.DataPropertyName = "ID_SALON";
            this.iDSALONDataGridViewTextBoxColumn.HeaderText = "ID_SALON";
            this.iDSALONDataGridViewTextBoxColumn.Name = "iDSALONDataGridViewTextBoxColumn";
            this.iDSALONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSALONDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPERSONADataGridViewTextBoxColumn
            // 
            this.iDPERSONADataGridViewTextBoxColumn.DataPropertyName = "ID_PERSONA";
            this.iDPERSONADataGridViewTextBoxColumn.HeaderText = "ID_PERSONA";
            this.iDPERSONADataGridViewTextBoxColumn.Name = "iDPERSONADataGridViewTextBoxColumn";
            this.iDPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPERSONADataGridViewTextBoxColumn.Visible = false;
            // 
            // iDRESERVADataGridViewTextBoxColumn
            // 
            this.iDRESERVADataGridViewTextBoxColumn.DataPropertyName = "ID_RESERVA";
            this.iDRESERVADataGridViewTextBoxColumn.HeaderText = "ID_RESERVA";
            this.iDRESERVADataGridViewTextBoxColumn.Name = "iDRESERVADataGridViewTextBoxColumn";
            this.iDRESERVADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRESERVADataGridViewTextBoxColumn.Visible = false;
            // 
            // hDESDEDataGridViewTextBoxColumn
            // 
            this.hDESDEDataGridViewTextBoxColumn.DataPropertyName = "H_DESDE";
            this.hDESDEDataGridViewTextBoxColumn.HeaderText = "H_DESDE";
            this.hDESDEDataGridViewTextBoxColumn.Name = "hDESDEDataGridViewTextBoxColumn";
            this.hDESDEDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDESDEDataGridViewTextBoxColumn.Visible = false;
            // 
            // hHASTADataGridViewTextBoxColumn
            // 
            this.hHASTADataGridViewTextBoxColumn.DataPropertyName = "H_HASTA";
            this.hHASTADataGridViewTextBoxColumn.HeaderText = "H_HASTA";
            this.hHASTADataGridViewTextBoxColumn.Name = "hHASTADataGridViewTextBoxColumn";
            this.hHASTADataGridViewTextBoxColumn.ReadOnly = true;
            this.hHASTADataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTIVODataGridViewTextBoxColumn
            // 
            this.aCTIVODataGridViewTextBoxColumn.DataPropertyName = "ACTIVO";
            this.aCTIVODataGridViewTextBoxColumn.HeaderText = "ACTIVO";
            this.aCTIVODataGridViewTextBoxColumn.Name = "aCTIVODataGridViewTextBoxColumn";
            this.aCTIVODataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTIVODataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHADataGridViewTextBoxColumn.Visible = false;
            // 
            // desdeSrtDataGridViewTextBoxColumn
            // 
            this.desdeSrtDataGridViewTextBoxColumn.DataPropertyName = "DesdeSrt";
            this.desdeSrtDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.desdeSrtDataGridViewTextBoxColumn.Name = "desdeSrtDataGridViewTextBoxColumn";
            this.desdeSrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaSrtDataGridViewTextBoxColumn
            // 
            this.hastaSrtDataGridViewTextBoxColumn.DataPropertyName = "HastaSrt";
            this.hastaSrtDataGridViewTextBoxColumn.HeaderText = "Hasta";
            this.hastaSrtDataGridViewTextBoxColumn.Name = "hastaSrtDataGridViewTextBoxColumn";
            this.hastaSrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALONDataGridViewTextBoxColumn
            // 
            this.sALONDataGridViewTextBoxColumn.DataPropertyName = "SALON";
            this.sALONDataGridViewTextBoxColumn.HeaderText = "Salon";
            this.sALONDataGridViewTextBoxColumn.Name = "sALONDataGridViewTextBoxColumn";
            this.sALONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPENOMDataGridViewTextBoxColumn
            // 
            this.aPENOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aPENOMDataGridViewTextBoxColumn.DataPropertyName = "APE_NOM";
            this.aPENOMDataGridViewTextBoxColumn.HeaderText = "A Cargo de";
            this.aPENOMDataGridViewTextBoxColumn.Name = "aPENOMDataGridViewTextBoxColumn";
            this.aPENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOPERSONADataGridViewTextBoxColumn
            // 
            this.tIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PERSONA";
            this.tIPOPERSONADataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPOPERSONADataGridViewTextBoxColumn.Name = "tIPOPERSONADataGridViewTextBoxColumn";
            this.tIPOPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ButtonLB";
            this.dataGridViewTextBoxColumn1.HeaderText = "ButtonLB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // test
            // 
            this.test.DataPropertyName = "ButtonLB";
            this.test.HeaderText = "";
            this.test.Name = "test";
            this.test.ReadOnly = true;
            this.test.Text = "";
            // 
            // InicioGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 464);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InicioGrilla";
            this.Text = "InicioGrilla";
            this.Load += new System.EventHandler(this.InicioGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prestamosEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonLBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROYECTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSALONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRESERVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDESDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hHASTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desdeSrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn test;
        private System.Windows.Forms.BindingSource prestamosEntityBindingSource;
    }
}