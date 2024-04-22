namespace saglıkOcagıOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnhastabak = new System.Windows.Forms.Button();
            this.btnhastakayıt = new System.Windows.Forms.Button();
            this.btnilackayit = new System.Windows.Forms.Button();
            this.btnrecetelistele = new System.Windows.Forms.Button();
            this.btnmuayanedefteri = new System.Windows.Forms.Button();
            this.btnilaclistele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ DR.ARTURO JIMENEZ";
            // 
            // btnhastabak
            // 
            this.btnhastabak.Location = new System.Drawing.Point(151, 162);
            this.btnhastabak.Name = "btnhastabak";
            this.btnhastabak.Size = new System.Drawing.Size(486, 54);
            this.btnhastabak.TabIndex = 1;
            this.btnhastabak.Text = "HASTA MUAYENE ";
            this.btnhastabak.UseVisualStyleBackColor = true;
            this.btnhastabak.Click += new System.EventHandler(this.btnhastabak_Click);
            // 
            // btnhastakayıt
            // 
            this.btnhastakayıt.Location = new System.Drawing.Point(151, 233);
            this.btnhastakayıt.Name = "btnhastakayıt";
            this.btnhastakayıt.Size = new System.Drawing.Size(486, 54);
            this.btnhastakayıt.TabIndex = 2;
            this.btnhastakayıt.Text = "HASTA KAYIT";
            this.btnhastakayıt.UseVisualStyleBackColor = true;
            this.btnhastakayıt.Click += new System.EventHandler(this.btnhastakayıt_Click);
            // 
            // btnilackayit
            // 
            this.btnilackayit.Location = new System.Drawing.Point(151, 305);
            this.btnilackayit.Name = "btnilackayit";
            this.btnilackayit.Size = new System.Drawing.Size(486, 54);
            this.btnilackayit.TabIndex = 3;
            this.btnilackayit.Text = "İLAÇ KAYIT";
            this.btnilackayit.UseVisualStyleBackColor = true;
            this.btnilackayit.Click += new System.EventHandler(this.btnilackayit_Click);
            // 
            // btnrecetelistele
            // 
            this.btnrecetelistele.Location = new System.Drawing.Point(96, 398);
            this.btnrecetelistele.Name = "btnrecetelistele";
            this.btnrecetelistele.Size = new System.Drawing.Size(155, 40);
            this.btnrecetelistele.TabIndex = 4;
            this.btnrecetelistele.Text = "RECETE LİSTELE";
            this.btnrecetelistele.UseVisualStyleBackColor = true;
            this.btnrecetelistele.Click += new System.EventHandler(this.btnrecetelistele_Click);
            // 
            // btnmuayanedefteri
            // 
            this.btnmuayanedefteri.Location = new System.Drawing.Point(310, 398);
            this.btnmuayanedefteri.Name = "btnmuayanedefteri";
            this.btnmuayanedefteri.Size = new System.Drawing.Size(160, 40);
            this.btnmuayanedefteri.TabIndex = 5;
            this.btnmuayanedefteri.Text = "MUAYANE DEFTERİ";
            this.btnmuayanedefteri.UseVisualStyleBackColor = true;
            this.btnmuayanedefteri.Click += new System.EventHandler(this.btnmuayanedefteri_Click);
            // 
            // btnilaclistele
            // 
            this.btnilaclistele.Location = new System.Drawing.Point(537, 398);
            this.btnilaclistele.Name = "btnilaclistele";
            this.btnilaclistele.Size = new System.Drawing.Size(149, 40);
            this.btnilaclistele.TabIndex = 6;
            this.btnilaclistele.Text = "İLAÇ LİSTELEME";
            this.btnilaclistele.UseVisualStyleBackColor = true;
            this.btnilaclistele.Click += new System.EventHandler(this.btnilaclistele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnilaclistele);
            this.Controls.Add(this.btnmuayanedefteri);
            this.Controls.Add(this.btnrecetelistele);
            this.Controls.Add(this.btnilackayit);
            this.Controls.Add(this.btnhastakayıt);
            this.Controls.Add(this.btnhastabak);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HOMEPAGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhastabak;
        private System.Windows.Forms.Button btnhastakayıt;
        private System.Windows.Forms.Button btnilackayit;
        private System.Windows.Forms.Button btnrecetelistele;
        private System.Windows.Forms.Button btnmuayanedefteri;
        private System.Windows.Forms.Button btnilaclistele;
    }
}

