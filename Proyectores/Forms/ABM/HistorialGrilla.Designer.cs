namespace Proyectores.Forms.ABM {
    partial class HistorialGrilla {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Desde_TP = new System.Windows.Forms.DateTimePicker();
            this.Hasta_TP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Modo_CB = new System.Windows.Forms.ComboBox();
            this.reportModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Registros_LB = new System.Windows.Forms.Label();
            this.Consulta_BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportModeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(24, 112);
            this.Grid.Name = "Grid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowTemplate.Height = 28;
            this.Grid.Size = new System.Drawing.Size(1016, 448);
            this.Grid.TabIndex = 0;
            // 
            // Desde_TP
            // 
            this.Desde_TP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Desde_TP.Location = new System.Drawing.Point(72, 0);
            this.Desde_TP.MinimumSize = new System.Drawing.Size(112, 28);
            this.Desde_TP.Name = "Desde_TP";
            this.Desde_TP.Size = new System.Drawing.Size(136, 28);
            this.Desde_TP.TabIndex = 1;
            this.Desde_TP.ValueChanged += new System.EventHandler(this.Dates_ValueChanged);
            // 
            // Hasta_TP
            // 
            this.Hasta_TP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Hasta_TP.Location = new System.Drawing.Point(272, 0);
            this.Hasta_TP.MinimumSize = new System.Drawing.Size(112, 28);
            this.Hasta_TP.Name = "Hasta_TP";
            this.Hasta_TP.Size = new System.Drawing.Size(136, 28);
            this.Hasta_TP.TabIndex = 2;
            this.Hasta_TP.ValueChanged += new System.EventHandler(this.Dates_ValueChanged);
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(208, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Hasta_TP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Desde_TP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 28);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Modo_CB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(24, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 28);
            this.panel2.TabIndex = 8;
            // 
            // Modo_CB
            // 
            this.Modo_CB.DataSource = this.reportModeBindingSource;
            this.Modo_CB.DisplayMember = "MLabel";
            this.Modo_CB.FormattingEnabled = true;
            this.Modo_CB.Location = new System.Drawing.Point(72, 0);
            this.Modo_CB.Name = "Modo_CB";
            this.Modo_CB.Size = new System.Drawing.Size(528, 28);
            this.Modo_CB.TabIndex = 11;
            this.Modo_CB.ValueMember = "MType";
            // 
            // reportModeBindingSource
            // 
            this.reportModeBindingSource.DataSource = typeof(Proyectores.Classes.ReportMode);
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reporte:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Registros_LB
            // 
            this.Registros_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Registros_LB.Location = new System.Drawing.Point(24, 568);
            this.Registros_LB.Name = "Registros_LB";
            this.Registros_LB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Registros_LB.Size = new System.Drawing.Size(1020, 32);
            this.Registros_LB.TabIndex = 9;
            this.Registros_LB.Text = "<Entries> ";
            this.Registros_LB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Consulta_BT
            // 
            this.Consulta_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Consulta_BT.Image = global::Proyectores.Properties.Resources.magnify;
            this.Consulta_BT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Consulta_BT.Location = new System.Drawing.Point(896, 16);
            this.Consulta_BT.Name = "Consulta_BT";
            this.Consulta_BT.Size = new System.Drawing.Size(144, 70);
            this.Consulta_BT.TabIndex = 9;
            this.Consulta_BT.Text = "Ejecutar Consulta";
            this.Consulta_BT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Consulta_BT.UseVisualStyleBackColor = true;
            this.Consulta_BT.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // HistorialGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 609);
            this.Controls.Add(this.Consulta_BT);
            this.Controls.Add(this.Registros_LB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid);
            this.Name = "HistorialGrilla";
            this.Text = "HistorialGrilla";
            this.Load += new System.EventHandler(this.HistorialGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportModeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker Desde_TP;
        private System.Windows.Forms.DateTimePicker Hasta_TP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Registros_LB;
        private System.Windows.Forms.Button Consulta_BT;
        private System.Windows.Forms.BindingSource reportTypeBindingSource;
        private System.Windows.Forms.BindingSource reportModeBindingSource;
        private System.Windows.Forms.ComboBox Modo_CB;
    }
}