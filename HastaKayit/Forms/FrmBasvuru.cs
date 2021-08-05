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
    public partial class FrmBasvuru : FrmBase
    {
        public FrmBasvuru()
        {
            InitializeComponent();
        }

        public override void ListBoxGuncelle()
        {
            base.ListBoxGuncelle();
            foreach (var item in Classes.Lists.BasvuruList)
            {
                listBox1.Items.Add(item.Text);
            }
        }

        private void FrmBasvuru_Load(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            foreach (var item in Classes.Lists.DoktorList)
            {
                cmbDoktor.Items.Add(item.Text);
            }

            cmbHasta.Items.Clear();
            foreach (var item in Classes.Lists.HastaList)
            {
                cmbHasta.Items.Add(item.Text);
            }

            cmbKlinik.Items.Clear();
            foreach (var item in Classes.Lists.KlinikList)
            {
                cmbKlinik.Items.Add(item.Text);
            }



        }

        public override void btnKaydet_Click(object sender, EventArgs e)
        {
            if (nmrBasvuruNo.Value == -1|| dateTimePicker1.Value == null  || cmbDoktor.SelectedIndex == -1 || cmbHasta.SelectedIndex == -1 || cmbKlinik.SelectedIndex == -1 )
            {
                MessageBox.Show("Basvuru No, Basvuru Tarihi, Klinik, Doktor, Hasta ve Branş Boş Olamaz");
                return;
            }

            Classes.Basvuru basvuru = new Classes.Basvuru();
            basvuru.BasvuruNo = (long)nmrBasvuruNo.Value;
            basvuru.BasvuruTarihi = dateTimePicker1.Value;
            basvuru.SgkDurumu = (Enums.EnumSgkDurumu)cmbSgkTuru.SelectedIndex;
            basvuru.CalismaDurumu = (Enums.EnumCalismaDurumu)cmbCalismaDurmu.SelectedIndex;
            basvuru.Doktor = Classes.Lists.DoktorList[cmbDoktor.SelectedIndex];
            basvuru.Hasta = Classes.Lists.HastaList[cmbHasta.SelectedIndex];
            basvuru.Klinik = Classes.Lists.KlinikList[cmbKlinik.SelectedIndex];
                        
            Classes.Lists.BasvuruList.Add(basvuru);
            ListBoxGuncelle();
        }

        
        

    }
}
