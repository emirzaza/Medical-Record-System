namespace saglıkOcagıOtomasyonu
{
    partial class ilacKayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtilackodu = new System.Windows.Forms.TextBox();
            this.txtilacadi = new System.Windows.Forms.TextBox();
            this.txtilactipi = new System.Windows.Forms.TextBox();
            this.btnilackayit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLAÇ KODU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 257);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İLAÇ ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İLAÇ TİPİ";
            // 
            // txtilackodu
            // 
            this.txtilackodu.Location = new System.Drawing.Point(170, 199);
            this.txtilackodu.Name = "txtilackodu";
            this.txtilackodu.Size = new System.Drawing.Size(100, 22);
            this.txtilackodu.TabIndex = 3;
            // 
            // txtilacadi
            // 
            this.txtilacadi.Location = new System.Drawing.Point(170, 251);
            this.txtilacadi.Name = "txtilacadi";
            this.txtilacadi.Size = new System.Drawing.Size(100, 22);
            this.txtilacadi.TabIndex = 4;
            // 
            // txtilactipi
            // 
            this.txtilactipi.Location = new System.Drawing.Point(170, 307);
            this.txtilactipi.Name = "txtilactipi";
            this.txtilactipi.Size = new System.Drawing.Size(100, 22);
            this.txtilactipi.TabIndex = 5;
            // 
            // btnilackayit
            // 
            this.btnilackayit.Location = new System.Drawing.Point(131, 372);
            this.btnilackayit.Name = "btnilackayit";
            this.btnilackayit.Size = new System.Drawing.Size(167, 40);
            this.btnilackayit.TabIndex = 6;
            this.btnilackayit.Text = "İLAÇ KAYDET";
            this.btnilackayit.UseVisualStyleBackColor = true;
            this.btnilackayit.Click += new System.EventHandler(this.btnilackayit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(29, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "SİSTEME İLAÇ KAYDET";
            // 
            // ilacKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnilackayit);
            this.Controls.Add(this.txtilactipi);
            this.Controls.Add(this.txtilacadi);
            this.Controls.Add(this.txtilackodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ilacKayıt";
            this.Text = "ilacKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtilackodu;
        private System.Windows.Forms.TextBox txtilacadi;
        private System.Windows.Forms.TextBox txtilactipi;
        private System.Windows.Forms.Button btnilackayit;
        private System.Windows.Forms.Label label4;
    }
}