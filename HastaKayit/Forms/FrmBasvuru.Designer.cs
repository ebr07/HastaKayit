
namespace _2021_01_21HastaKayitEbruGozmen.Forms
{
    partial class FrmBasvuru
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
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.lblBrans = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSgkTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKlinik = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCalismaDurmu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nmrBasvuruNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBasvuruNo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(33, 158);
            this.listBox1.Size = new System.Drawing.Size(780, 121);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(738, 285);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(657, 285);
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(565, 13);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(200, 21);
            this.cmbHasta.TabIndex = 0;
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrans.Location = new System.Drawing.Point(456, 18);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(57, 16);
            this.lblBrans.TabIndex = 1;
            this.lblBrans.Text = "Hasta :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(30, 49);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(112, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Başvuru Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Sgk Türü :";
            // 
            // cmbSgkTuru
            // 
            this.cmbSgkTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSgkTuru.FormattingEnabled = true;
            this.cmbSgkTuru.Items.AddRange(new object[] {
            "SSK",
            "Bagkur",
            "EmekliSandigi "});
            this.cmbSgkTuru.Location = new System.Drawing.Point(189, 80);
            this.cmbSgkTuru.Name = "cmbSgkTuru";
            this.cmbSgkTuru.Size = new System.Drawing.Size(200, 21);
            this.cmbSgkTuru.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(456, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Doktor:";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(565, 85);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(200, 21);
            this.cmbDoktor.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(456, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Klinik:";
            // 
            // cmbKlinik
            // 
            this.cmbKlinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlinik.FormattingEnabled = true;
            this.cmbKlinik.Location = new System.Drawing.Point(565, 52);
            this.cmbKlinik.Name = "cmbKlinik";
            this.cmbKlinik.Size = new System.Drawing.Size(200, 21);
            this.cmbKlinik.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Çalışma Durumu :";
            // 
            // cmbCalismaDurmu
            // 
            this.cmbCalismaDurmu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalismaDurmu.FormattingEnabled = true;
            this.cmbCalismaDurmu.Items.AddRange(new object[] {
            "Calisan ",
            "Calismayan ",
            "Emekli "});
            this.cmbCalismaDurmu.Location = new System.Drawing.Point(189, 126);
            this.cmbCalismaDurmu.Name = "cmbCalismaDurmu";
            this.cmbCalismaDurmu.Size = new System.Drawing.Size(200, 21);
            this.cmbCalismaDurmu.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Başvuru No :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 80;
            // 
            // nmrBasvuruNo
            // 
            this.nmrBasvuruNo.Location = new System.Drawing.Point(189, 8);
            this.nmrBasvuruNo.Name = "nmrBasvuruNo";
            this.nmrBasvuruNo.Size = new System.Drawing.Size(200, 20);
            this.nmrBasvuruNo.TabIndex = 81;
            // 
            // FrmBasvuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 371);
            this.Controls.Add(this.nmrBasvuruNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCalismaDurmu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKlinik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSgkTuru);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.cmbHasta);
            this.Name = "FrmBasvuru";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Başvuru";
            this.Load += new System.EventHandler(this.FrmBasvuru_Load);
            this.Controls.SetChildIndex(this.btnKapat, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.cmbHasta, 0);
            this.Controls.SetChildIndex(this.lblBrans, 0);
            this.Controls.SetChildIndex(this.lblAd, 0);
            this.Controls.SetChildIndex(this.cmbSgkTuru, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbDoktor, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbKlinik, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbCalismaDurmu, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.nmrBasvuruNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmrBasvuruNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSgkTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKlinik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCalismaDurmu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown nmrBasvuruNo;
    }
}