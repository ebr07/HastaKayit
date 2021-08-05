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
    public partial class FrmLaboratuvarTetkik : FrmBase
    {
        public FrmLaboratuvarTetkik()
        {
            InitializeComponent();
        }

        public override void ListBoxGuncelle()
        {
            base.ListBoxGuncelle();
            foreach (var item in Classes.Lists.LaboratuvarTetkikList)
            {
                listBox1.Items.Add(item.Text);
            }
        }

        private void FrmLaboratuvarTetkik_Load(object sender, EventArgs e)
        {

        }

        public override void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtAd.Text == "")
            {
                MessageBox.Show("Ad ve Kod Boş Olamaz");
                return;
            }
            Classes.LaboratuvarTetkik laboratuvarTetkik = new Classes.LaboratuvarTetkik();
            laboratuvarTetkik.Ad =txtAd.Text;
            laboratuvarTetkik.Kod =txtKod.Text;
            Classes.Lists.LaboratuvarTetkikList.Add(laboratuvarTetkik);
            ListBoxGuncelle();
        }
    }
}
