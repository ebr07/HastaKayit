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
    public partial class FrmMuayene : FrmBase
    {
        public FrmMuayene()
        {
            InitializeComponent();
        }

        public override void ListBoxGuncelle()
        {
            base.ListBoxGuncelle();
            foreach (var item in Classes.Lists.MuayeneList)
            {
                listBox1.Items.Add(item.Text);
            }
        }

        private void FrmMuayene_Load(object sender, EventArgs e)
        {
            cmbMuayene.Items.Clear();
            foreach (var item in Classes.Lists.BasvuruList)
            {
                cmbMuayene.Items.Add(item.Text);
            }

            foreach (var item in Classes.Lists.TaniList)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.Kod + " - " + item.Ad;
                flpTanilar.Controls.Add(cb);
            }

            foreach(var item in Classes.Lists.IslemList)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.Kod + " - " + item.Ad;
                flpIslem.Controls.Add(cb);
            }
            foreach (var item in Classes.Lists.LaboratuvarTetkikList)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.Kod + " - " + item.Ad;
                flpLaboratuvar.Controls.Add(cb);
            }




        }

        public override void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMuayene.SelectedIndex == -1 || dateTimePicker1.Value == null || flpTanilar.Controls.Count == -1 || flpIslem.Controls.Count == -1)
            {
                MessageBox.Show("Basvuru, Muayene Zamanı, Tani, ve işlem Boş Olamaz");
                return;
            }

            Classes.Muayene muayene = new Classes.Muayene();
            muayene.MuayeneZamani = dateTimePicker1.Value;
            muayene.Basvuru = Classes.Lists.BasvuruList[cmbMuayene.SelectedIndex];
            foreach (var item in flpTanilar.Controls)
            {
                CheckBox cb = item as CheckBox;
                if(cb.Checked)
                    muayene.Tani += cb.Text + ",";
            }
            muayene.Tani = muayene.Tani.Trim(',');

            foreach (var item in flpIslem.Controls)
            {
                CheckBox cb = item as CheckBox;
                if (cb.Checked)
                    muayene.Islem += cb.Text + ",";
            }
            muayene.Islem = muayene.Islem.Trim(',');


            foreach (var item in flpLaboratuvar.Controls)
            {
                CheckBox cb = item as CheckBox;
                if (cb.Checked)
                    muayene.LaboratuvarTetkikleri += cb.Text + ",";
            }
            muayene.LaboratuvarTetkikleri = muayene.LaboratuvarTetkikleri.Trim(',');


            Classes.Lists.MuayeneList.Add(muayene);
            ListBoxGuncelle();
        }
    }
}
