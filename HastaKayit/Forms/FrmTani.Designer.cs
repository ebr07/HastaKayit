
namespace _2021_01_21HastaKayitEbruGozmen.Forms
{
    partial class FrmTani
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
            this.lblBrans = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(15, 92);
            this.listBox1.Size = new System.Drawing.Size(824, 238);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(764, 336);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(672, 336);
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrans.Location = new System.Drawing.Point(12, 55);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(43, 16);
            this.lblBrans.TabIndex = 1;
            this.lblBrans.Text = "Kod :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(12, 22);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(91, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(107, 20);
            this.txtAd.TabIndex = 6;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(91, 51);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(107, 20);
            this.txtKod.TabIndex = 70;
            // 
            // FrmTani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 375);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblBrans);
            this.Name = "FrmTani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tanı";
            this.Load += new System.EventHandler(this.FrmTani_Load);
            this.Controls.SetChildIndex(this.btnKapat, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.lblBrans, 0);
            this.Controls.SetChildIndex(this.lblAd, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtKod, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKod;
    }
}