namespace saglıkOcagıOtomasyonu
{
    partial class receteListele
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
            this.gridlistelerecete = new System.Windows.Forms.DataGridView();
            this.btnlistelerecete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridlistelerecete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridlistelerecete
            // 
            this.gridlistelerecete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridlistelerecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlistelerecete.Location = new System.Drawing.Point(34, 12);
            this.gridlistelerecete.Name = "gridlistelerecete";
            this.gridlistelerecete.RowHeadersWidth = 51;
            this.gridlistelerecete.RowTemplate.Height = 24;
            this.gridlistelerecete.Size = new System.Drawing.Size(742, 326);
            this.gridlistelerecete.TabIndex = 0;
            // 
            // btnlistelerecete
            // 
            this.btnlistelerecete.Location = new System.Drawing.Point(318, 369);
            this.btnlistelerecete.Name = "btnlistelerecete";
            this.btnlistelerecete.Size = new System.Drawing.Size(130, 56);
            this.btnlistelerecete.TabIndex = 1;
            this.btnlistelerecete.Text = "GÖSTER";
            this.btnlistelerecete.UseVisualStyleBackColor = true;
            this.btnlistelerecete.Click += new System.EventHandler(this.btnlistelerecete_Click);
            // 
            // receteListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlistelerecete);
            this.Controls.Add(this.gridlistelerecete);
            this.Name = "receteListele";
            this.Text = "receteListele";
            ((System.ComponentModel.ISupportInitialize)(this.gridlistelerecete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridlistelerecete;
        private System.Windows.Forms.Button btnlistelerecete;
    }
}