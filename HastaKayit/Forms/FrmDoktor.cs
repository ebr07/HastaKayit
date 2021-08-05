using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_01_21HastaKayitEbruGozmen.Forms
{
    public partial class FrmDoktor : FrmBase
    {
        public FrmDoktor()
        {
            InitializeComponent();
        }

        public override void ListBoxGuncelle()
        {
            base.ListBoxGuncelle();
            foreach (var item in Classes.Lists.DoktorList)
            {
                listBox1.Items.Add(item.Text);
            }
        }

        private void FrmDoktor_Load(object sender, EventArgs e)
        {

        }

        public override void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTCKNo.Text == "" || txtAdSoyad.Text ==""  || txtTelefonNo.Text == "" || cmbBrans.SelectedIndex == -1  )
            {
                MessageBox.Show("TC Kimlik No , Ad Soyad ,Telefon Numarası ve Branş Boş Olamaz");
                return;
            }

            Classes.Doktor doktor = new Classes.Doktor();
            doktor.TCKNo = txtTCKNo.Text;
            doktor.AdSoyad = txtAdSoyad.Text;
            doktor.DogumTarihi = dt.Value;
            doktor.TelefonNo = txtTelefonNo.Text;
            doktor.KanGrubu = (Enums.EnumKanGrubu)cmbKanGrubu.SelectedIndex;
            doktor.Brans = (Enums.EnumBrans)cmbBrans.SelectedIndex;
            doktor.UzmanlikDurumu = (Enums.EnumUzmanlikDurumu)cmbUzmanlikDurumu.SelectedIndex;
            Classes.Lists.DoktorList.Add(doktor);
            ListBoxGuncelle();
        }
    }
}
