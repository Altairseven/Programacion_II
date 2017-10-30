namespace Proyectores.Forms {
    partial class Main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TB_Control = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TabInicio = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabProyectores = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabAjustes = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabReservas = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPersonas = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TB_Control)).BeginInit();
            this.TB_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Control
            // 
            this.TB_Control.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.TB_Control.BeforeTouchSize = new System.Drawing.Size(1233, 744);
            this.TB_Control.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Control.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.TB_Control.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.TB_Control.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.TB_Control.Controls.Add(this.TabInicio);
            this.TB_Control.Controls.Add(this.TabReservas);
            this.TB_Control.Controls.Add(this.TabPersonas);
            this.TB_Control.Controls.Add(this.TabProyectores);
            this.TB_Control.Controls.Add(this.TabAjustes);
            this.TB_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Control.FocusOnTabClick = false;
            this.TB_Control.ImageList = this.imageList1;
            this.TB_Control.InActiveTabForeColor = System.Drawing.Color.Black;
            this.TB_Control.ItemSize = new System.Drawing.Size(150, 60);
            this.TB_Control.Location = new System.Drawing.Point(0, 0);
            this.TB_Control.Margin = new System.Windows.Forms.Padding(0);
            this.TB_Control.Multiline = true;
            this.TB_Control.Name = "TB_Control";
            this.TB_Control.RotateTextWhenVertical = true;
            this.TB_Control.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Control.ShowSeparator = false;
            this.TB_Control.Size = new System.Drawing.Size(1233, 744);
            this.TB_Control.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.FillToRight;
            this.TB_Control.TabIndex = 1;
            this.TB_Control.TabPanelBackColor = System.Drawing.SystemColors.Control;
            this.TB_Control.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.TB_Control.SelectedIndexChanged += new System.EventHandler(this.TB_Control_SelectedIndexChanged);
            this.TB_Control.TabIndexChanged += new System.EventHandler(this.TB_Control_TabIndexChanged);
            // 
            // TabInicio
            // 
            this.TabInicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TabInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabInicio.ForeColor = System.Drawing.Color.Black;
            this.TabInicio.Image = null;
            this.TabInicio.ImageIndex = 0;
            this.TabInicio.ImageSize = new System.Drawing.Size(16, 16);
            this.TabInicio.Location = new System.Drawing.Point(0, 40);
            this.TabInicio.Margin = new System.Windows.Forms.Padding(0);
            this.TabInicio.Name = "TabInicio";
            this.TabInicio.ShowCloseButton = true;
            this.TabInicio.Size = new System.Drawing.Size(1233, 704);
            this.TabInicio.TabForeColor = System.Drawing.Color.White;
            this.TabInicio.TabIndex = 1;
            this.TabInicio.Text = "  Inicio";
            this.TabInicio.ThemesEnabled = false;
            // 
            // TabProyectores
            // 
            this.TabProyectores.Image = null;
            this.TabProyectores.ImageIndex = 3;
            this.TabProyectores.ImageSize = new System.Drawing.Size(16, 16);
            this.TabProyectores.Location = new System.Drawing.Point(0, 40);
            this.TabProyectores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProyectores.Name = "TabProyectores";
            this.TabProyectores.ShowCloseButton = true;
            this.TabProyectores.Size = new System.Drawing.Size(1233, 704);
            this.TabProyectores.TabIndex = 4;
            this.TabProyectores.Text = "  Proyectores";
            this.TabProyectores.ThemesEnabled = false;
            // 
            // TabAjustes
            // 
            this.TabAjustes.Image = null;
            this.TabAjustes.ImageIndex = 7;
            this.TabAjustes.ImageSize = new System.Drawing.Size(16, 16);
            this.TabAjustes.Location = new System.Drawing.Point(0, 40);
            this.TabAjustes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabAjustes.Name = "TabAjustes";
            this.TabAjustes.ShowCloseButton = true;
            this.TabAjustes.Size = new System.Drawing.Size(1233, 704);
            this.TabAjustes.TabIndex = 5;
            this.TabAjustes.Text = " Historial";
            this.TabAjustes.ThemesEnabled = false;
            // 
            // TabReservas
            // 
            this.TabReservas.Image = null;
            this.TabReservas.ImageIndex = 1;
            this.TabReservas.ImageSize = new System.Drawing.Size(16, 16);
            this.TabReservas.Location = new System.Drawing.Point(0, 40);
            this.TabReservas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabReservas.Name = "TabReservas";
            this.TabReservas.ShowCloseButton = true;
            this.TabReservas.Size = new System.Drawing.Size(1233, 704);
            this.TabReservas.TabIndex = 2;
            this.TabReservas.Text = "  Reservas";
            this.TabReservas.ThemesEnabled = false;
            // 
            // TabPersonas
            // 
            this.TabPersonas.Image = null;
            this.TabPersonas.ImageIndex = 2;
            this.TabPersonas.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPersonas.Location = new System.Drawing.Point(0, 40);
            this.TabPersonas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPersonas.Name = "TabPersonas";
            this.TabPersonas.ShowCloseButton = true;
            this.TabPersonas.Size = new System.Drawing.Size(1233, 704);
            this.TabPersonas.TabIndex = 3;
            this.TabPersonas.Text = "  Personas";
            this.TabPersonas.ThemesEnabled = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "house.png");
            this.imageList1.Images.SetKeyName(1, "calendar-clock.png");
            this.imageList1.Images.SetKeyName(2, "user-male.png");
            this.imageList1.Images.SetKeyName(3, "device-camera.png");
            this.imageList1.Images.SetKeyName(4, "wrench.png");
            this.imageList1.Images.SetKeyName(5, "wrench-screwdriver.png");
            this.imageList1.Images.SetKeyName(6, "file-video.png");
            this.imageList1.Images.SetKeyName(7, "clock.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 744);
            this.Controls.Add(this.TB_Control);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1250, 788);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TB_Control)).EndInit();
            this.TB_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv TB_Control;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TabInicio;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TabReservas;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TabPersonas;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TabProyectores;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TabAjustes;
    }
}