namespace Proyectores.Forms.ABM {
    partial class LocalidadGrilla {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lb_Info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.DelBT = new System.Windows.Forms.Button();
            this.EditBT = new System.Windows.Forms.Button();
            this.AgregarBT = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadesEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Info
            // 
            this.Lb_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Info.Location = new System.Drawing.Point(405, 244);
            this.Lb_Info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Info.Name = "Lb_Info";
            this.Lb_Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lb_Info.Size = new System.Drawing.Size(403, 13);
            this.Lb_Info.TabIndex = 3;
            this.Lb_Info.Text = "<Entries>";
            this.Lb_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView1.DataSource = this.localidadesEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(797, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Search_TB
            // 
            this.Search_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_TB.Location = new System.Drawing.Point(683, 10);
            this.Search_TB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(127, 20);
            this.Search_TB.TabIndex = 7;
            this.Search_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_TB_KeyDown);
            this.Search_TB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_TB_KeyUp);
            // 
            // DelBT
            // 
            this.DelBT.Image = global::Proyectores.Properties.Resources.trashcan;
            this.DelBT.Location = new System.Drawing.Point(192, 244);
            this.DelBT.Margin = new System.Windows.Forms.Padding(2);
            this.DelBT.Name = "DelBT";
            this.DelBT.Size = new System.Drawing.Size(85, 31);
            this.DelBT.TabIndex = 6;
            this.DelBT.Text = "Eliminar";
            this.DelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DelBT.UseVisualStyleBackColor = true;
            this.DelBT.Click += new System.EventHandler(this.DelBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.Image = global::Proyectores.Properties.Resources.pencil;
            this.EditBT.Location = new System.Drawing.Point(101, 244);
            this.EditBT.Margin = new System.Windows.Forms.Padding(2);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(85, 31);
            this.EditBT.TabIndex = 5;
            this.EditBT.Text = "Editar";
            this.EditBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditBT.UseVisualStyleBackColor = true;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // AgregarBT
            // 
            this.AgregarBT.Image = global::Proyectores.Properties.Resources.sign_add;
            this.AgregarBT.Location = new System.Drawing.Point(11, 244);
            this.AgregarBT.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarBT.Name = "AgregarBT";
            this.AgregarBT.Size = new System.Drawing.Size(85, 31);
            this.AgregarBT.TabIndex = 4;
            this.AgregarBT.Text = "Agregar";
            this.AgregarBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBT.UseVisualStyleBackColor = true;
            this.AgregarBT.Click += new System.EventHandler(this.AgregarBT_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "COD_POSTAL";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn7.DividerWidth = 1;
            this.dataGridViewTextBoxColumn7.HeaderText = "Cod. Postal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID_PROVINCIA";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID_PROVINCIA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NOMBRE_PROVINCIA";
            this.dataGridViewTextBoxColumn10.HeaderText = "Provincia";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // localidadesEntityBindingSource
            // 
            this.localidadesEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.LocalidadesEntity);
            // 
            // LocalidadGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 294);
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.DelBT);
            this.Controls.Add(this.EditBT);
            this.Controls.Add(this.AgregarBT);
            this.Controls.Add(this.Lb_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(621, 333);
            this.Name = "LocalidadGrilla";
            this.Text = "LocalidadGrilla";
            this.Load += new System.EventHandler(this.LocalidadGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AgregarBT;
        private System.Windows.Forms.Label Lb_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBT;
        private System.Windows.Forms.Button DelBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPOSTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROVINCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPROVINCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODAREATELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource localidadesEntityBindingSource;
        private System.Windows.Forms.TextBox Search_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}