using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_01_21HastaKayitEbruGozmen.Classes
{
    public class Kisi : Base
    {
        public string AdSoyad { get; set; }
        public string TCKNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Enums.EnumKanGrubu KanGrubu { get; set; }

        public string TelefonNo { get; set; }
        public string Adres { get; set; }

        public string Meslek { get; set; }
    }
}
