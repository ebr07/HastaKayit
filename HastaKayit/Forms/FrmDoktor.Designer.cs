
namespace _2021_01_21HastaKayitEbruGozmen.Forms
{
    partial class FrmDoktor
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
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.lblKanGrubu = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUzmanlikDurumu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(25, 227);
            this.listBox1.Size = new System.Drawing.Size(780, 121);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(752, 395);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(671, 395);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Items.AddRange(new object[] {
            "A Rh +",
            "A Rh -",
            "B Rh +",
            "B Rh -",
            "AB Rh +",
            "AB Rh -",
            "0 Rh +",
            "0 Rh -"});
            this.cmbKanGrubu.Location = new System.Drawing.Point(562, 23);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(200, 21);
            this.cmbKanGrubu.TabIndex = 83;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(562, 139);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(243, 73);
            this.txtAdres.TabIndex = 81;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(167, 138);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(200, 20);
            this.txtTelefonNo.TabIndex = 80;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(167, 98);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 20);
            this.dt.TabIndex = 79;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(167, 64);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(200, 20);
            this.txtAdSoyad.TabIndex = 78;
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(167, 28);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(200, 20);
            this.txtTCKNo.TabIndex = 77;
            // 
            // lblKanGrubu
            // 
            this.lblKanGrubu.AutoSize = true;
            this.lblKanGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKanGrubu.Location = new System.Drawing.Point(396, 32);
            this.lblKanGrubu.Name = "lblKanGrubu";
            this.lblKanGrubu.Size = new System.Drawing.Size(87, 16);
            this.lblKanGrubu.TabIndex = 74;
            this.lblKanGrubu.Text = "Kan Grubu :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(22, 138);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(69, 16);
            this.lblTelefon.TabIndex = 75;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(22, 68);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(84, 16);
            this.lblAdSoyad.TabIndex = 73;
            this.lblAdSoyad.Text = "Ad Soyad :";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(22, 102);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(109, 16);
            this.lblDogumTarihi.TabIndex = 72;
            this.lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(396, 139);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(57, 16);
            this.lblAdres.TabIndex = 71;
            this.lblAdres.Text = "Adres :";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.Location = new System.Drawing.Point(22, 28);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(60, 16);
            this.lblTcNo.TabIndex = 70;
            this.lblTcNo.Text = "TC No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(396, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "Branş :";
            // 
            // cmbUzmanlikDurumu
            // 
            this.cmbUzmanlikDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUzmanlikDurumu.FormattingEnabled = true;
            this.cmbUzmanlikDurumu.Items.AddRange(new object[] {
            "Pratisyen ",
            "Uzman ",
            "Docent ",
            "Profesor ",
            "Operator "});
            this.cmbUzmanlikDurumu.Location = new System.Drawing.Point(562, 101);
            this.cmbUzmanlikDurumu.Name = "cmbUzmanlikDurumu";
            this.cmbUzmanlikDurumu.Size = new System.Drawing.Size(200, 21);
            this.cmbUzmanlikDurumu.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(395, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Uzmanlik Durumu :";
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
            this.cmbBrans.Location = new System.Drawing.Point(562, 67);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(200, 21);
            this.cmbBrans.TabIndex = 87;
            // 
            // FrmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 436);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.cmbUzmanlikDurumu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKanGrubu);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTCKNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKanGrubu);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTcNo);
            this.Name = "FrmDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.FrmDoktor_Load);
            this.Controls.SetChildIndex(this.lblTcNo, 0);
            this.Controls.SetChildIndex(this.lblAdres, 0);
            this.Controls.SetChildIndex(this.lblDogumTarihi, 0);
            this.Controls.SetChildIndex(this.lblAdSoyad, 0);
            this.Controls.SetChildIndex(this.lblTelefon, 0);
            this.Controls.SetChildIndex(this.lblKanGrubu, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTCKNo, 0);
            this.Controls.SetChildIndex(this.txtAdSoyad, 0);
            this.Controls.SetChildIndex(this.dt, 0);
            this.Controls.SetChildIndex(this.txtTelefonNo, 0);
            this.Controls.SetChildIndex(this.txtAdres, 0);
            this.Controls.SetChildIndex(this.cmbKanGrubu, 0);
            this.Controls.SetChildIndex(this.btnKapat, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbUzmanlikDurumu, 0);
            this.Controls.SetChildIndex(this.cmbBrans, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKanGrubu;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.Label lblKanGrubu;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUzmanlikDurumu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrans;
    }
}