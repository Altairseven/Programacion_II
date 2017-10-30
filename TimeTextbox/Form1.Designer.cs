namespace TimeTextbox {
    partial class Form1 {
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
            this.timeTextBox2 = new TimeTextbox.TimeTextBox();
            this.timeTextBox1 = new TimeTextbox.TimeTextBox();
            this.timePicker1 = new Proyectores.TimePicker();
            this.SuspendLayout();
            // 
            // timeTextBox2
            // 
            this.timeTextBox2.Location = new System.Drawing.Point(88, 104);
            this.timeTextBox2.Mask = "00:00";
            this.timeTextBox2.Name = "timeTextBox2";
            this.timeTextBox2.Size = new System.Drawing.Size(64, 26);
            this.timeTextBox2.TabIndex = 1;
            this.timeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.timeTextBox1.Location = new System.Drawing.Point(88, 56);
            this.timeTextBox1.Mask = "00:00";
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.Size = new System.Drawing.Size(64, 26);
            this.timeTextBox1.TabIndex = 0;
            this.timeTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // timePicker1
            // 
            this.timePicker1.Hours = 0;
            this.timePicker1.Location = new System.Drawing.Point(104, 152);
            this.timePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timePicker1.Milliseconds = 0;
            this.timePicker1.Minutes = 0;
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.Seconds = 0;
            this.timePicker1.Size = new System.Drawing.Size(112, 31);
            this.timePicker1.TabIndex = 3;
            this.timePicker1.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.timePicker1);
            this.Controls.Add(this.timeTextBox2);
            this.Controls.Add(this.timeTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TimeTextBox timeTextBox1;
        private TimeTextBox timeTextBox2;
        private Proyectores.TimePicker timePicker1;
    }
}

