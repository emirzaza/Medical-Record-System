namespace saglıkOcagıOtomasyonu
{
    partial class muayaneDefteri
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
            this.gridlistelemuayane = new System.Windows.Forms.DataGridView();
            this.btnlistelemuayane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridlistelemuayane)).BeginInit();
            this.SuspendLayout();
            // 
            // gridlistelemuayane
            // 
            this.gridlistelemuayane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridlistelemuayane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlistelemuayane.Location = new System.Drawing.Point(40, 12);
            this.gridlistelemuayane.Name = "gridlistelemuayane";
            this.gridlistelemuayane.RowHeadersWidth = 51;
            this.gridlistelemuayane.RowTemplate.Height = 24;
            this.gridlistelemuayane.Size = new System.Drawing.Size(713, 401);
            this.gridlistelemuayane.TabIndex = 0;
            // 
            // btnlistelemuayane
            // 
            this.btnlistelemuayane.Location = new System.Drawing.Point(325, 428);
            this.btnlistelemuayane.Name = "btnlistelemuayane";
            this.btnlistelemuayane.Size = new System.Drawing.Size(115, 36);
            this.btnlistelemuayane.TabIndex = 1;
            this.btnlistelemuayane.Text = "GÖSTER";
            this.btnlistelemuayane.UseVisualStyleBackColor = true;
            this.btnlistelemuayane.Click += new System.EventHandler(this.btnlistelemuayane_Click);
            // 
            // muayaneDefteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnlistelemuayane);
            this.Controls.Add(this.gridlistelemuayane);
            this.Name = "muayaneDefteri";
            this.Text = "muayaneDefteri";
            ((System.ComponentModel.ISupportInitialize)(this.gridlistelemuayane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridlistelemuayane;
        private System.Windows.Forms.Button btnlistelemuayane;
    }
}