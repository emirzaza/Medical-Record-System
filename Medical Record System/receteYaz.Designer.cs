namespace saglıkOcagıOtomasyonu
{
    partial class receteYaz
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
            this.txtilac1 = new System.Windows.Forms.TextBox();
            this.txtilac5 = new System.Windows.Forms.TextBox();
            this.txtilac4 = new System.Windows.Forms.TextBox();
            this.txtilac3 = new System.Windows.Forms.TextBox();
            this.txtilac2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrecetekaydet = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.cb5 = new System.Windows.Forms.ComboBox();
            this.gridilaclistele = new System.Windows.Forms.DataGridView();
            this.btnilacgöster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridilaclistele)).BeginInit();
            this.SuspendLayout();
            // 
            // txtilac1
            // 
            this.txtilac1.Location = new System.Drawing.Point(50, 94);
            this.txtilac1.Name = "txtilac1";
            this.txtilac1.Size = new System.Drawing.Size(149, 22);
            this.txtilac1.TabIndex = 0;
            this.txtilac1.Text = "1.ilaç Yazılmadı";
            // 
            // txtilac5
            // 
            this.txtilac5.Location = new System.Drawing.Point(50, 281);
            this.txtilac5.Name = "txtilac5";
            this.txtilac5.Size = new System.Drawing.Size(149, 22);
            this.txtilac5.TabIndex = 8;
            this.txtilac5.Text = "5.ilaç Yazılmadı";
            // 
            // txtilac4
            // 
            this.txtilac4.Location = new System.Drawing.Point(50, 238);
            this.txtilac4.Name = "txtilac4";
            this.txtilac4.Size = new System.Drawing.Size(149, 22);
            this.txtilac4.TabIndex = 12;
            this.txtilac4.Text = "4. ilaç Yazılmadı";
            // 
            // txtilac3
            // 
            this.txtilac3.Location = new System.Drawing.Point(50, 188);
            this.txtilac3.Name = "txtilac3";
            this.txtilac3.Size = new System.Drawing.Size(149, 22);
            this.txtilac3.TabIndex = 13;
            this.txtilac3.Text = "3.ilaç Yazılmadı";
            // 
            // txtilac2
            // 
            this.txtilac2.Location = new System.Drawing.Point(50, 138);
            this.txtilac2.Name = "txtilac2";
            this.txtilac2.Size = new System.Drawing.Size(149, 22);
            this.txtilac2.TabIndex = 14;
            this.txtilac2.Text = "2.ilaç Yazılmadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "İLAÇ KODU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "ADET";
            // 
            // btnrecetekaydet
            // 
            this.btnrecetekaydet.Location = new System.Drawing.Point(78, 350);
            this.btnrecetekaydet.Name = "btnrecetekaydet";
            this.btnrecetekaydet.Size = new System.Drawing.Size(121, 40);
            this.btnrecetekaydet.TabIndex = 18;
            this.btnrecetekaydet.Text = "KAYDET";
            this.btnrecetekaydet.UseVisualStyleBackColor = true;
            this.btnrecetekaydet.Click += new System.EventHandler(this.btnrecetekaydet_Click);
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "-",
            "1",
            "2",
            "3"});
            this.cb1.Location = new System.Drawing.Point(215, 94);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(40, 24);
            this.cb1.TabIndex = 19;
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "-",
            "1",
            "2",
            "3"});
            this.cb2.Location = new System.Drawing.Point(214, 138);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(40, 24);
            this.cb2.TabIndex = 21;
            // 
            // cb3
            // 
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "-",
            "1",
            "2",
            "3"});
            this.cb3.Location = new System.Drawing.Point(214, 188);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(40, 24);
            this.cb3.TabIndex = 22;
            // 
            // cb4
            // 
            this.cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb4.FormattingEnabled = true;
            this.cb4.Items.AddRange(new object[] {
            "-",
            "1",
            "2",
            "3"});
            this.cb4.Location = new System.Drawing.Point(214, 238);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(40, 24);
            this.cb4.TabIndex = 23;
            // 
            // cb5
            // 
            this.cb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb5.FormattingEnabled = true;
            this.cb5.Items.AddRange(new object[] {
            "-",
            "1",
            "2",
            "3"});
            this.cb5.Location = new System.Drawing.Point(215, 281);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(40, 24);
            this.cb5.TabIndex = 24;
            // 
            // gridilaclistele
            // 
            this.gridilaclistele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridilaclistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridilaclistele.Location = new System.Drawing.Point(311, 79);
            this.gridilaclistele.Name = "gridilaclistele";
            this.gridilaclistele.RowHeadersWidth = 51;
            this.gridilaclistele.RowTemplate.Height = 24;
            this.gridilaclistele.Size = new System.Drawing.Size(317, 224);
            this.gridilaclistele.TabIndex = 25;
            // 
            // btnilacgöster
            // 
            this.btnilacgöster.Location = new System.Drawing.Point(378, 318);
            this.btnilacgöster.Name = "btnilacgöster";
            this.btnilacgöster.Size = new System.Drawing.Size(154, 32);
            this.btnilacgöster.TabIndex = 26;
            this.btnilacgöster.Text = "ilaçları göster";
            this.btnilacgöster.UseVisualStyleBackColor = true;
            this.btnilacgöster.Click += new System.EventHandler(this.btnilacgöster_Click);
            // 
            // receteYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 405);
            this.Controls.Add(this.btnilacgöster);
            this.Controls.Add(this.gridilaclistele);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.btnrecetekaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtilac2);
            this.Controls.Add(this.txtilac3);
            this.Controls.Add(this.txtilac4);
            this.Controls.Add(this.txtilac5);
            this.Controls.Add(this.txtilac1);
            this.Name = "receteYaz";
            this.Text = "receteYaz";
            this.Load += new System.EventHandler(this.receteYaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridilaclistele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtilac1;
        private System.Windows.Forms.TextBox txtilac5;
        private System.Windows.Forms.TextBox txtilac4;
        private System.Windows.Forms.TextBox txtilac3;
        private System.Windows.Forms.TextBox txtilac2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrecetekaydet;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.ComboBox cb5;
        private System.Windows.Forms.DataGridView gridilaclistele;
        private System.Windows.Forms.Button btnilacgöster;
    }
}