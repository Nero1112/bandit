namespace бандит
{
    partial class Бандит
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
            this.startbtn = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.dvig1 = new System.Windows.Forms.Timer(this.components);
            this.dvig2 = new System.Windows.Forms.Timer(this.components);
            this.dvig3 = new System.Windows.Forms.Timer(this.components);
            this.stop1 = new System.Windows.Forms.Timer(this.components);
            this.stop2 = new System.Windows.Forms.Timer(this.components);
            this.stop3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.Red;
            this.startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startbtn.Location = new System.Drawing.Point(87, 54);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(111, 83);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "старт";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Yellow;
            this.l1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.Location = new System.Drawing.Point(34, 160);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(71, 75);
            this.l1.TabIndex = 1;
            this.l1.Text = "0";
            this.l1.Click += new System.EventHandler(this.l1_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Yellow;
            this.l2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2.Location = new System.Drawing.Point(111, 160);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(71, 75);
            this.l2.TabIndex = 2;
            this.l2.Text = "0";
            this.l2.Click += new System.EventHandler(this.l2_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Yellow;
            this.l3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l3.Location = new System.Drawing.Point(185, 160);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(71, 75);
            this.l3.TabIndex = 3;
            this.l3.Text = "0";
            this.l3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dvig1
            // 
            this.dvig1.Interval = 10;
            this.dvig1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dvig2
            // 
            this.dvig2.Interval = 10;
            this.dvig2.Tick += new System.EventHandler(this.dvig2_Tick);
            // 
            // dvig3
            // 
            this.dvig3.Interval = 10;
            this.dvig3.Tick += new System.EventHandler(this.dvig3_Tick);
            // 
            // stop1
            // 
            this.stop1.Interval = 1000;
            this.stop1.Tick += new System.EventHandler(this.stop1_Tick);
            // 
            // stop2
            // 
            this.stop2.Interval = 1500;
            this.stop2.Tick += new System.EventHandler(this.stop2_Tick);
            // 
            // stop3
            // 
            this.stop3.Interval = 1900;
            this.stop3.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Бандит
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.startbtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Бандит";
            this.Text = "Бандит";
            this.Load += new System.EventHandler(this.Бандит_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Timer dvig1;
        private System.Windows.Forms.Timer dvig2;
        private System.Windows.Forms.Timer dvig3;
        private System.Windows.Forms.Timer stop1;
        private System.Windows.Forms.Timer stop2;
        private System.Windows.Forms.Timer stop3;
    }
}

