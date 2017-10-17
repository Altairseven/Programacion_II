namespace Proyectores.Forms {
    partial class Principal {
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Personas");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Reservas");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Prestamos Actuales");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Proyectores");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Principal", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Localidades");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ajustes", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCloseBT = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.localidadesEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.localidadesEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Location = new System.Drawing.Point(8, 32);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Personas";
            treeNode1.Text = "Personas";
            treeNode2.Name = "Reservas";
            treeNode2.Text = "Reservas";
            treeNode3.Name = "PrestamosActivos";
            treeNode3.Text = "Prestamos Actuales";
            treeNode4.Name = "Proyectores";
            treeNode4.Text = "Proyectores";
            treeNode5.Name = "Principal";
            treeNode5.Text = "Principal";
            treeNode6.Name = "Localidades";
            treeNode6.Text = "Localidades";
            treeNode7.Name = "Ajustes";
            treeNode7.Text = "Ajustes";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(184, 407);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(200, 32);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 409);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // TabCloseBT
            // 
            this.TabCloseBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCloseBT.Location = new System.Drawing.Point(1003, 0);
            this.TabCloseBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabCloseBT.Name = "TabCloseBT";
            this.TabCloseBT.Size = new System.Drawing.Size(52, 26);
            this.TabCloseBT.TabIndex = 5;
            this.TabCloseBT.Text = "X";
            this.TabCloseBT.UseVisualStyleBackColor = true;
            this.TabCloseBT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "house.png");
            this.imageList1.Images.SetKeyName(1, "calendar-clock.png");
            this.imageList1.Images.SetKeyName(2, "file-video.png");
            this.imageList1.Images.SetKeyName(3, "user-male.png");
            // 
            // localidadesEntityBindingSource
            // 
            this.localidadesEntityBindingSource.DataSource = typeof(Proyectores.Model.Entities.LocalidadesEntity);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 472);
            this.Controls.Add(this.TabCloseBT);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1078, 519);
            this.Name = "Principal";
            this.Text = "Proyectores";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKey_Listener);
            ((System.ComponentModel.ISupportInitialize)(this.localidadesEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button TabCloseBT;
        private System.Windows.Forms.BindingSource localidadesEntityBindingSource;
        private System.Windows.Forms.ImageList imageList1;
    }
}

