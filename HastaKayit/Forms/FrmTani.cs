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
    public partial class FrmTani : FrmBase
    {
        public FrmTani()
        {
            InitializeComponent();
        }

        public override void ListBoxGuncelle()
        {
            base.ListBoxGuncelle();
            foreach (var item in Classes.Lists.TaniList)
            {
                listBox1.Items.Add(item.Text);
            }
        }

        private void FrmTani_Load(object sender, EventArgs e)
        {

        }

        public override void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtKod.Text == "")
            {
                MessageBox.Show("Ad ve Kod Boş Olamaz");
                return;
            }
            Classes.Tani tani = new Classes.Tani();
            tani.Ad =txtAd.Text;
            tani.Kod =txtKod.Text;
            Classes.Lists.TaniList.Add(tani);
            ListBoxGuncelle();
        }
    }
}
