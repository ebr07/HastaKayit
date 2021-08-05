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
    public partial class FrmHasta : FrmBase
    {
        public FrmHasta()
        {
            InitializeComponent();
        }

        public override void ListBoxGuncelle()
        {
            base.ListBoxGuncelle();
            foreach (var item in Classes.Lists.HastaList)
            {
                listBox1.Items.Add(item.Text);
            }
        }

        private void FrmHasta_Load(object sender, EventArgs e)
        {

        }

        public override void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTCKNo.Text == "" || txtAdSoyad.Text == "" || txtTelefonNo.Text == "" )
            {
                MessageBox.Show("TC Kimlik No , Ad Soyad ve Telefon Numarası Boş Olamaz");
                return;
            }
            Classes.Hasta hasta = new Classes.Hasta();
            hasta.TCKNo = txtTCKNo.Text;
            hasta.AdSoyad = txtAdSoyad.Text;
            hasta.DogumTarihi = dt.Value;
            hasta.TelefonNo = txtTelefonNo.Text;
            hasta.KanGrubu = (Enums.EnumKanGrubu)cmbKanGrubu.SelectedIndex;
            hasta.Meslek = txtMeslek.Text;
            hasta.Adres = txtAdres.Text;
            
            Classes.Lists.HastaList.Add(hasta);
            ListBoxGuncelle();
        }
    }
}
