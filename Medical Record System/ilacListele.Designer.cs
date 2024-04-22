namespace saglıkOcagıOtomasyonu
{
    partial class ilacListele
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngösterhastanınilacları = new System.Windows.Forms.Button();
            this.gridhastanınilacları = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttchasta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridilacınhastaları = new System.Windows.Forms.DataGridView();
            this.btngösterilacrecetesi = new System.Windows.Forms.Button();
            this.txtilacno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridhastanınilacları)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridilacınhastaları)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btngösterhastanınilacları);
            this.groupBox1.Controls.Add(this.gridhastanınilacları);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttchasta);
            this.groupBox1.Location = new System.Drawing.Point(49, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HASTANIN İLAÇLARINI ARA";
            // 
            // btngösterhastanınilacları
            // 
            this.btngösterhastanınilacları.Location = new System.Drawing.Point(126, 325);
            this.btngösterhastanınilacları.Name = "btngösterhastanınilacları";
            this.btngösterhastanınilacları.Size = new System.Drawing.Size(75, 23);
            this.btngösterhastanınilacları.TabIndex = 3;
            this.btngösterhastanınilacları.Text = "GÖSTER";
            this.btngösterhastanınilacları.UseVisualStyleBackColor = true;
            this.btngösterhastanınilacları.Click += new System.EventHandler(this.btngösterhastanınilacları_Click);
            // 
            // gridhastanınilacları
            // 
            this.gridhastanınilacları.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridhastanınilacları.Location = new System.Drawing.Point(35, 80);
            this.gridhastanınilacları.Name = "gridhastanınilacları";
            this.gridhastanınilacları.RowHeadersWidth = 51;
            this.gridhastanınilacları.RowTemplate.Height = 24;
            this.gridhastanınilacları.Size = new System.Drawing.Size(283, 221);
            this.gridhastanınilacları.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA TC Sİ GİRİNİZ";
            // 
            // txttchasta
            // 
            this.txttchasta.Location = new System.Drawing.Point(199, 42);
            this.txttchasta.Name = "txttchasta";
            this.txttchasta.Size = new System.Drawing.Size(147, 22);
            this.txttchasta.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.btngösterilacrecetesi);
            this.groupBox2.Controls.Add(this.gridilacınhastaları);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtilacno);
            this.groupBox2.Location = new System.Drawing.Point(422, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İLACIN REÇETELERİNİ ARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İLAC NUMARASI GİRİNİZ";
            // 
            // gridilacınhastaları
            // 
            this.gridilacınhastaları.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridilacınhastaları.Location = new System.Drawing.Point(36, 84);
            this.gridilacınhastaları.Name = "gridilacınhastaları";
            this.gridilacınhastaları.RowHeadersWidth = 51;
            this.gridilacınhastaları.RowTemplate.Height = 24;
            this.gridilacınhastaları.Size = new System.Drawing.Size(287, 217);
            this.gridilacınhastaları.TabIndex = 3;
            // 
            // btngösterilacrecetesi
            // 
            this.btngösterilacrecetesi.Location = new System.Drawing.Point(134, 325);
            this.btngösterilacrecetesi.Name = "btngösterilacrecetesi";
            this.btngösterilacrecetesi.Size = new System.Drawing.Size(75, 23);
            this.btngösterilacrecetesi.TabIndex = 4;
            this.btngösterilacrecetesi.Text = "GÖSTER";
            this.btngösterilacrecetesi.UseVisualStyleBackColor = true;
            this.btngösterilacrecetesi.Click += new System.EventHandler(this.btngösterilacrecetesi_Click);
            // 
            // txtilacno
            // 
            this.txtilacno.Location = new System.Drawing.Point(206, 45);
            this.txtilacno.Name = "txtilacno";
            this.txtilacno.Size = new System.Drawing.Size(140, 22);
            this.txtilacno.TabIndex = 1;
            // 
            // ilacListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ilacListele";
            this.Text = "ilacListele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridhastanınilacları)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridilacınhastaları)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngösterhastanınilacları;
        private System.Windows.Forms.DataGridView gridhastanınilacları;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttchasta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngösterilacrecetesi;
        private System.Windows.Forms.DataGridView gridilacınhastaları;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtilacno;
    }
}