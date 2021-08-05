
namespace _2021_01_21HastaKayitEbruGozmen.Forms
{
    partial class FrmMuayene
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
            this.cmbMuayene = new System.Windows.Forms.ComboBox();
            this.lblBrans = new System.Windows.Forms.Label();
            this.flpTanilar = new System.Windows.Forms.FlowLayoutPanel();
            this.flpIslem = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLaboratuvar = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(12, 315);
            this.listBox1.Size = new System.Drawing.Size(806, 121);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(743, 442);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(662, 442);
            // 
            // cmbMuayene
            // 
            this.cmbMuayene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMuayene.FormattingEnabled = true;
            this.cmbMuayene.Items.AddRange(new object[] {
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
            this.cmbMuayene.Location = new System.Drawing.Point(164, 17);
            this.cmbMuayene.Name = "cmbMuayene";
            this.cmbMuayene.Size = new System.Drawing.Size(654, 21);
            this.cmbMuayene.TabIndex = 0;
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrans.Location = new System.Drawing.Point(9, 17);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(119, 16);
            this.lblBrans.TabIndex = 1;
            this.lblBrans.Text = "Başvuru Bilgisi :";
            // 
            // flpTanilar
            // 
            this.flpTanilar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpTanilar.Location = new System.Drawing.Point(12, 104);
            this.flpTanilar.Name = "flpTanilar";
            this.flpTanilar.Size = new System.Drawing.Size(227, 205);
            this.flpTanilar.TabIndex = 70;
            // 
            // flpIslem
            // 
            this.flpIslem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpIslem.Location = new System.Drawing.Point(300, 104);
            this.flpIslem.Name = "flpIslem";
            this.flpIslem.Size = new System.Drawing.Size(234, 205);
            this.flpIslem.TabIndex = 71;
            // 
            // flpLaboratuvar
            // 
            this.flpLaboratuvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpLaboratuvar.Location = new System.Drawing.Point(593, 104);
            this.flpLaboratuvar.Name = "flpLaboratuvar";
            this.flpLaboratuvar.Size = new System.Drawing.Size(225, 205);
            this.flpLaboratuvar.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(600, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "LABORATUVAR TETKİKLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(369, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "İŞLEMLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "TANILAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Muayene Zamanı :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // FrmMuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 508);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpIslem);
            this.Controls.Add(this.flpLaboratuvar);
            this.Controls.Add(this.flpTanilar);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.cmbMuayene);
            this.Name = "FrmMuayene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Muayene";
            this.Load += new System.EventHandler(this.FrmMuayene_Load);
            this.Controls.SetChildIndex(this.btnKapat, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.cmbMuayene, 0);
            this.Controls.SetChildIndex(this.lblBrans, 0);
            this.Controls.SetChildIndex(this.flpTanilar, 0);
            this.Controls.SetChildIndex(this.flpLaboratuvar, 0);
            this.Controls.SetChildIndex(this.flpIslem, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMuayene;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.FlowLayoutPanel flpTanilar;
        private System.Windows.Forms.FlowLayoutPanel flpIslem;
        private System.Windows.Forms.FlowLayoutPanel flpLaboratuvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}