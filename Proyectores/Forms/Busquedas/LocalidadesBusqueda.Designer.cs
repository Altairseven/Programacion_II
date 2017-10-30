namespace Proyectores.Forms.Busquedas {
    partial class LocalidadesBusqueda {
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPOSTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPROVINCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPROVINCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadesEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Search_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesEntityBindingSource)).BeginInit();
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
            this.cODPOSTALDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.iDPROVINCIADataGridViewTextBoxColumn,
            this.nOMBREPROVINCIADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.localidadesEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 270);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnGrid_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODPOSTALDataGridViewTextBoxColumn
            // 
            this.cODPOSTALDataGridViewTextBoxColumn.DataPropertyName = "COD_POSTAL";
            this.cODPOSTALDataGridViewTextBoxColumn.HeaderText = "C.P.";
            this.cODPOSTALDataGridViewTextBoxColumn.Name = "cODPOSTALDataGridViewTextBoxColumn";
            this.cODPOSTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPROVINCIADataGridViewTextBoxColumn
            // 
            this.iDPROVINCIADataGridViewTextBoxColumn.DataPropertyName = "ID_PROVINCIA";
            this.iDPROVINCIADataGridViewTextBoxColumn.HeaderText = "ID_PROVINCIA";
            this.iDPROVINCIADataGridViewTextBoxColumn.Name = "iDPROVINCIADataGridViewTextBoxColumn";
            this.iDPROVINCIADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPROVINCIADataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMBREPROVINCIADataGridViewTextBoxColumn
            // 
            this.nOMBREPROVINCIADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PROVINCIA";
            this.nOMBREPROVINCIADataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.nOMBREPROVINCIADataGridViewTextBoxColumn.Name = "nOMBREPROVINCIADataGridViewTextBoxColumn";
            this.nOMBREPROVINCIADataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBREPROVINCIADataGridViewTextBoxColumn.Width = 150;
            // 
            // localidadesEntityBindingSource
            // 
            this.localidadesEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.LocalidadesEntity);
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
            // LocalidadesBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 346);
            this.ControlBox = false;
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LocalidadesBusqueda";
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.LocalidadesBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPOSTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROVINCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPROVINCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource localidadesEntityBindingSource;
    }
}