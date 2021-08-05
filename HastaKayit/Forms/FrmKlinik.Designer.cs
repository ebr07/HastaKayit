
namespace _2021_01_21HastaKayitEbruGozmen.Forms
{
    partial class FrmKlinik
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
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.lblBrans = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(12, 67);
            this.listBox1.Size = new System.Drawing.Size(780, 121);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(717, 194);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(636, 194);
            // 
            // cmbBrans
            // 
            this.cmbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Items.AddRange(new object[] {
            "Dahiliye ",
            "Dermatoloji",
            "Kardiyoloji ",
            "KBB ",
            "GöğüsHastalıkları ",
            "Göz ",
            "Enfeksiyon ",
            "FTR ",
            "Nöroloji",
            "Ortopedi",
            "GenelCerrahi ",
            "Dis "});
            this.cmbBrans.Location = new System.Drawing.Point(121, 38);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(200, 21);
            this.cmbBrans.TabIndex = 0;
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrans.Location = new System.Drawing.Point(13, 41);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(56, 16);
            this.lblBrans.TabIndex = 1;
            this.lblBrans.Text = "Brans :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(13, 12);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 20);
            this.txtAd.TabIndex = 6;
            // 
            // FrmKlinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 256);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.cmbBrans);
            this.Name = "FrmKlinik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Klinik";
            this.Load += new System.EventHandler(this.FrmKlinik_Load);
            this.Controls.SetChildIndex(this.btnKapat, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.cmbBrans, 0);
            this.Controls.SetChildIndex(this.lblBrans, 0);
            this.Controls.SetChildIndex(this.lblAd, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
    }
}