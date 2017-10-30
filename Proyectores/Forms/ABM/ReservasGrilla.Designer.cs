namespace Proyectores.Forms.ABM {
    partial class ReservasGrilla {
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
            this.Registros_LB = new System.Windows.Forms.Label();
            this.Date_LB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Calendar = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            this.DelBT = new System.Windows.Forms.Button();
            this.AgregarBT = new System.Windows.Forms.Button();
            this.EditBT = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSALONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHARESERVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAALTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHABAJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMOTIVOBAJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDESDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hHASTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESALONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRETIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDESDEsrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hHASTAsrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservasEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasEntityBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDSALONDataGridViewTextBoxColumn,
            this.iDPERSONADataGridViewTextBoxColumn,
            this.fECHARESERVADataGridViewTextBoxColumn,
            this.fECHAALTADataGridViewTextBoxColumn,
            this.fECHABAJADataGridViewTextBoxColumn,
            this.iDMOTIVOBAJADataGridViewTextBoxColumn,
            this.hDESDEDataGridViewTextBoxColumn,
            this.hHASTADataGridViewTextBoxColumn,
            this.nOMBRESALONDataGridViewTextBoxColumn,
            this.nOMBRETIPOPERSONADataGridViewTextBoxColumn,
            this.aPENOMDataGridViewTextBoxColumn,
            this.hDESDEsrtDataGridViewTextBoxColumn,
            this.hHASTAsrtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservasEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(376, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(704, 472);
            this.dataGridView1.TabIndex = 2;
            // 
            // Registros_LB
            // 
            this.Registros_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Registros_LB.Location = new System.Drawing.Point(376, 496);
            this.Registros_LB.Name = "Registros_LB";
            this.Registros_LB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Registros_LB.Size = new System.Drawing.Size(708, 32);
            this.Registros_LB.TabIndex = 7;
            this.Registros_LB.Text = "<Entries> ";
            this.Registros_LB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date_LB
            // 
            this.Date_LB.BackColor = System.Drawing.SystemColors.Window;
            this.Date_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date_LB.Location = new System.Drawing.Point(16, 16);
            this.Date_LB.Name = "Date_LB";
            this.Date_LB.Size = new System.Drawing.Size(342, 32);
            this.Date_LB.TabIndex = 10;
            this.Date_LB.Text = "<Date>";
            this.Date_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Calendar);
            this.panel1.Controls.Add(this.Date_LB);
            this.panel1.Controls.Add(this.DelBT);
            this.panel1.Controls.Add(this.AgregarBT);
            this.panel1.Controls.Add(this.EditBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 544);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Image = global::Proyectores.Properties.Resources.magnify1;
            this.button1.Location = new System.Drawing.Point(16, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ver";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calendar
            // 
            this.Calendar.AllowMultipleSelection = false;
            this.Calendar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Calendar.BottomHeight = 34;
            this.Calendar.Culture = new System.Globalization.CultureInfo("es-AR");
            this.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.Calendar.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.Calendar.HeaderFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.HeaderHeight = 34;
            this.Calendar.HeaderStartColor = System.Drawing.Color.White;
            this.Calendar.HighlightColor = System.Drawing.Color.Black;
            this.Calendar.Iso8601CalenderFormat = false;
            this.Calendar.Location = new System.Drawing.Point(16, 56);
            this.Calendar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.Calendar.Name = "Calendar";
            this.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.Calendar.Size = new System.Drawing.Size(344, 240);
            this.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.Calendar.TabIndex = 18;
            this.Calendar.TodayButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            // 
            // 
            // 
            this.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Calendar.NoneButton.AutoSize = true;
            this.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.Calendar.NoneButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Calendar.NoneButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Calendar.NoneButton.IsBackStageButton = false;
            this.Calendar.NoneButton.Location = new System.Drawing.Point(272, 0);
            this.Calendar.NoneButton.Size = new System.Drawing.Size(72, 34);
            this.Calendar.NoneButton.Text = "None";
            this.Calendar.NoneButton.UseVisualStyle = true;
            this.Calendar.NoneButton.Visible = false;
            // 
            // 
            // 
            this.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Calendar.TodayButton.AutoSize = true;
            this.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.Calendar.TodayButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Calendar.TodayButton.ForeColor = System.Drawing.Color.Black;
            this.Calendar.TodayButton.IsBackStageButton = false;
            this.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.Calendar.TodayButton.Margin = new System.Windows.Forms.Padding(0);
            this.Calendar.TodayButton.Size = new System.Drawing.Size(344, 34);
            this.Calendar.TodayButton.Text = "Today";
            this.Calendar.TodayButton.UseVisualStyle = true;
            this.Calendar.DateChanged += new System.EventHandler(this.Calendar_SelectionChanged);
            // 
            // DelBT
            // 
            this.DelBT.Image = global::Proyectores.Properties.Resources.sign_ban;
            this.DelBT.Location = new System.Drawing.Point(192, 416);
            this.DelBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelBT.Name = "DelBT";
            this.DelBT.Size = new System.Drawing.Size(168, 48);
            this.DelBT.TabIndex = 15;
            this.DelBT.Text = "Cancelar";
            this.DelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DelBT.UseVisualStyleBackColor = true;
            this.DelBT.Click += new System.EventHandler(this.DelBT_Click);
            // 
            // AgregarBT
            // 
            this.AgregarBT.Image = global::Proyectores.Properties.Resources.sign_add;
            this.AgregarBT.Location = new System.Drawing.Point(16, 304);
            this.AgregarBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarBT.Name = "AgregarBT";
            this.AgregarBT.Size = new System.Drawing.Size(344, 48);
            this.AgregarBT.TabIndex = 13;
            this.AgregarBT.Text = "Agregar";
            this.AgregarBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBT.UseVisualStyleBackColor = true;
            this.AgregarBT.Click += new System.EventHandler(this.AgregarBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.Image = global::Proyectores.Properties.Resources.pencil;
            this.EditBT.Location = new System.Drawing.Point(16, 416);
            this.EditBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(168, 48);
            this.EditBT.TabIndex = 14;
            this.EditBT.Text = "Editar";
            this.EditBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditBT.UseVisualStyleBackColor = true;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
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
            // fECHARESERVADataGridViewTextBoxColumn
            // 
            this.fECHARESERVADataGridViewTextBoxColumn.DataPropertyName = "FECHA_RESERVA";
            this.fECHARESERVADataGridViewTextBoxColumn.HeaderText = "FECHA_RESERVA";
            this.fECHARESERVADataGridViewTextBoxColumn.Name = "fECHARESERVADataGridViewTextBoxColumn";
            this.fECHARESERVADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHARESERVADataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAALTADataGridViewTextBoxColumn
            // 
            this.fECHAALTADataGridViewTextBoxColumn.DataPropertyName = "FECHA_ALTA";
            this.fECHAALTADataGridViewTextBoxColumn.HeaderText = "FECHA_ALTA";
            this.fECHAALTADataGridViewTextBoxColumn.Name = "fECHAALTADataGridViewTextBoxColumn";
            this.fECHAALTADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAALTADataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHABAJADataGridViewTextBoxColumn
            // 
            this.fECHABAJADataGridViewTextBoxColumn.DataPropertyName = "FECHA_BAJA";
            this.fECHABAJADataGridViewTextBoxColumn.HeaderText = "FECHA_BAJA";
            this.fECHABAJADataGridViewTextBoxColumn.Name = "fECHABAJADataGridViewTextBoxColumn";
            this.fECHABAJADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHABAJADataGridViewTextBoxColumn.Visible = false;
            // 
            // iDMOTIVOBAJADataGridViewTextBoxColumn
            // 
            this.iDMOTIVOBAJADataGridViewTextBoxColumn.DataPropertyName = "ID_MOTIVO_BAJA";
            this.iDMOTIVOBAJADataGridViewTextBoxColumn.HeaderText = "ID_MOTIVO_BAJA";
            this.iDMOTIVOBAJADataGridViewTextBoxColumn.Name = "iDMOTIVOBAJADataGridViewTextBoxColumn";
            this.iDMOTIVOBAJADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMOTIVOBAJADataGridViewTextBoxColumn.Visible = false;
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
            // nOMBRESALONDataGridViewTextBoxColumn
            // 
            this.nOMBRESALONDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_SALON";
            this.nOMBRESALONDataGridViewTextBoxColumn.HeaderText = "Salon";
            this.nOMBRESALONDataGridViewTextBoxColumn.Name = "nOMBRESALONDataGridViewTextBoxColumn";
            this.nOMBRESALONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRETIPOPERSONADataGridViewTextBoxColumn
            // 
            this.nOMBRETIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_TIPO_PERSONA";
            this.nOMBRETIPOPERSONADataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.nOMBRETIPOPERSONADataGridViewTextBoxColumn.Name = "nOMBRETIPOPERSONADataGridViewTextBoxColumn";
            this.nOMBRETIPOPERSONADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPENOMDataGridViewTextBoxColumn
            // 
            this.aPENOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aPENOMDataGridViewTextBoxColumn.DataPropertyName = "APE_NOM";
            this.aPENOMDataGridViewTextBoxColumn.HeaderText = "Nombre, Apellido";
            this.aPENOMDataGridViewTextBoxColumn.Name = "aPENOMDataGridViewTextBoxColumn";
            this.aPENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hDESDEsrtDataGridViewTextBoxColumn
            // 
            this.hDESDEsrtDataGridViewTextBoxColumn.DataPropertyName = "H_DESDEsrt";
            this.hDESDEsrtDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.hDESDEsrtDataGridViewTextBoxColumn.Name = "hDESDEsrtDataGridViewTextBoxColumn";
            this.hDESDEsrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hHASTAsrtDataGridViewTextBoxColumn
            // 
            this.hHASTAsrtDataGridViewTextBoxColumn.DataPropertyName = "H_HASTAsrt";
            this.hHASTAsrtDataGridViewTextBoxColumn.HeaderText = "Hasta";
            this.hHASTAsrtDataGridViewTextBoxColumn.Name = "hHASTAsrtDataGridViewTextBoxColumn";
            this.hHASTAsrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservasEntityBindingSource
            // 
            this.reservasEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.ReservasEntity);
            // 
            // ReservasGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Registros_LB);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReservasGrilla";
            this.Text = "ReservasGrilla";
            this.Load += new System.EventHandler(this.ReservasGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSALONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHARESERVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAALTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHABAJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMOTIVOBAJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDESDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hHASTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESALONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRETIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDESDEsrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hHASTAsrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservasEntityBindingSource;
        private System.Windows.Forms.Label Registros_LB;
        private System.Windows.Forms.Label Date_LB;
        private System.Windows.Forms.Button DelBT;
        private System.Windows.Forms.Button EditBT;
        private System.Windows.Forms.Button AgregarBT;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.MonthCalendarAdv Calendar;
        private System.Windows.Forms.Button button1;
    }
}