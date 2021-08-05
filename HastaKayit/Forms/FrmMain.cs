using _2021_01_21HastaKayitEbruGozmen.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_01_21HastaKayitEbruGozmen
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void hastaBiligleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new FrmHasta());
        }

        void FormGoster(Form form)
        {
            this.Width = form.Width;
            this.Height = form.Height;

            bool formVarMi = false;
            foreach (Form item in this.MdiChildren)
            {
                
                if(item.Text==form.Text)
                {
                    formVarMi = true;
                    item.Activate();
                }
                else
                {

                    item.Close();
                }

            }

            if(!formVarMi)
            {

                form.MdiParent = this;
                form.Show();
            }



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Klinik_Click(object sender, EventArgs e)
        {
            FormGoster(new FrmKlinik());
        }

       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGoster(new FrmKlinik()); 
        }

        private void tanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new FrmTani());
        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new FrmDoktor());
        }

        private void başvuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            if (Classes.Lists.KlinikList.Count == 0)
            {
                mesaj = "Klinik,";
            }
            if (Classes.Lists.DoktorList.Count == 0)
            {
                mesaj += "Doktor,";
            }
            if (Classes.Lists.HastaList.Count == 0)
            {
                mesaj += "Hasta";
            }

            if (mesaj != "")
            {
                mesaj = mesaj.Trim(',') + " Tanımı Yapılmadığından Başvuru Yapılamaz.";
                MessageBox.Show(mesaj);
            }
            else
            {
                FormGoster(new FrmBasvuru());
            }
        }

        private void muayeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Classes.Lists.BasvuruList.Count == 0)
            {
                MessageBox.Show("Başvuru Yapılmadığından Muayene Yapılamaz.");
            }
            else
            {
                FormGoster(new FrmMuayene());
            }
        }

        private void laboratuvarTetkikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new FrmLaboratuvarTetkik());
        }

        private void yapılanİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new FrmIslem());
        }

        private void hastaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new FrmHasta());
        }
    }
}
