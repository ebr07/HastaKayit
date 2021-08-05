using _2021_01_21HastaKayitEbruGozmen.Interfaces;
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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        public virtual void ListBoxGuncelle()
        {
            listBox1.Items.Clear();
        }
        private void FrmKayit_Load(object sender, EventArgs e)
        {
            ListBoxGuncelle();
        }

        public virtual void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
