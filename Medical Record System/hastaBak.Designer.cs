namespace saglıkOcagıOtomasyonu
{
    partial class hastaBak
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
            this.TCNO = new System.Windows.Forms.Label();
            this.ŞİKAYET = new System.Windows.Forms.Label();
            this.TANI = new System.Windows.Forms.Label();
            this.btnreceteyaz = new System.Windows.Forms.Button();
            this.btnhastabak = new System.Windows.Forms.Button();
            this.txtsikayet = new System.Windows.Forms.TextBox();
            this.txttani = new System.Windows.Forms.TextBox();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TCNO
            // 
            this.TCNO.AutoSize = true;
            this.TCNO.Location = new System.Drawing.Point(85, 54);
            this.TCNO.Name = "TCNO";
            this.TCNO.Size = new System.Drawing.Size(45, 16);
            this.TCNO.TabIndex = 0;
            this.TCNO.Text = "TCNO";
            // 
            // ŞİKAYET
            // 
            this.ŞİKAYET.AutoSize = true;
            this.ŞİKAYET.Location = new System.Drawing.Point(67, 120);
            this.ŞİKAYET.Name = "ŞİKAYET";
            this.ŞİKAYET.Size = new System.Drawing.Size(63, 16);
            this.ŞİKAYET.TabIndex = 1;
            this.ŞİKAYET.Text = "ŞİKAYET";
            // 
            // TANI
            // 
            this.TANI.AutoSize = true;
            this.TANI.Location = new System.Drawing.Point(92, 190);
            this.TANI.Name = "TANI";
            this.TANI.Size = new System.Drawing.Size(38, 16);
            this.TANI.TabIndex = 3;
            this.TANI.Text = "TANI";
            // 
            // btnreceteyaz
            // 
            this.btnreceteyaz.Location = new System.Drawing.Point(88, 276);
            this.btnreceteyaz.Name = "btnreceteyaz";
            this.btnreceteyaz.Size = new System.Drawing.Size(168, 31);
            this.btnreceteyaz.TabIndex = 4;
            this.btnreceteyaz.Text = "RECETE YAZ";
            this.btnreceteyaz.UseVisualStyleBackColor = true;
            this.btnreceteyaz.Click += new System.EventHandler(this.btnreceteyaz_Click_2);
            // 
            // btnhastabak
            // 
            this.btnhastabak.Location = new System.Drawing.Point(70, 355);
            this.btnhastabak.Name = "btnhastabak";
            this.btnhastabak.Size = new System.Drawing.Size(198, 69);
            this.btnhastabak.TabIndex = 5;
            this.btnhastabak.Text = "GÖNDER";
            this.btnhastabak.UseVisualStyleBackColor = true;
            this.btnhastabak.Click += new System.EventHandler(this.btnhastabak_Click);
            // 
            // txtsikayet
            // 
            this.txtsikayet.Location = new System.Drawing.Point(156, 120);
            this.txtsikayet.Name = "txtsikayet";
            this.txtsikayet.Size = new System.Drawing.Size(100, 22);
            this.txtsikayet.TabIndex = 6;
            // 
            // txttani
            // 
            this.txttani.Location = new System.Drawing.Point(156, 190);
            this.txttani.Name = "txttani";
            this.txttani.Size = new System.Drawing.Size(100, 22);
            this.txttani.TabIndex = 7;
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(156, 54);
            this.txttcno.Name = "txttcno";
            this.txttcno.Size = new System.Drawing.Size(100, 22);
            this.txttcno.TabIndex = 8;
            // 
            // hastaBak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 451);
            this.Controls.Add(this.txttcno);
            this.Controls.Add(this.txttani);
            this.Controls.Add(this.txtsikayet);
            this.Controls.Add(this.btnhastabak);
            this.Controls.Add(this.btnreceteyaz);
            this.Controls.Add(this.TANI);
            this.Controls.Add(this.ŞİKAYET);
            this.Controls.Add(this.TCNO);
            this.Name = "hastaBak";
            this.Text = "hastaBak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TCNO;
        private System.Windows.Forms.Label ŞİKAYET;
        private System.Windows.Forms.Label TANI;
        private System.Windows.Forms.Button btnreceteyaz;
        private System.Windows.Forms.Button btnhastabak;
        private System.Windows.Forms.TextBox txtsikayet;
        private System.Windows.Forms.TextBox txttani;
        private System.Windows.Forms.TextBox txttcno;
    }
}