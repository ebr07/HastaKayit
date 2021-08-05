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
    public partial class FrmKlinik : FrmBase
    {
        public FrmKlinik()
        {
            InitializeComponent();
        }

        public override void ListBoxGuncelle()
        {
            base.ListBoxGuncelle();
            foreach (var item in Classes.Lists.KlinikList)
            {
                listBox1.Items.Add(item.Text);
            }
        }

        private void FrmKlinik_Load(object sender, EventArgs e)
        {

        }

        public override void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtAd.Text == "" || cmbBrans.SelectedIndex == -1)
            {
                MessageBox.Show("Ad ve Branş Boş Olamaz");
                return;
            }
            Classes.Klinik klinik = new Classes.Klinik();
            klinik.Ad = txtAd.Text;
            klinik.Brans = (Enums.EnumBrans)cmbBrans.SelectedIndex;
            Classes.Lists.KlinikList.Add(klinik);
            ListBoxGuncelle();
        }
    }
}
