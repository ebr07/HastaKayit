using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_21HastaKayitEbruGozmen.Classes
{
     public class Basvuru : Base , Interfaces.IText
    {
       
        public long BasvuruNo { get; set; }
        public DateTime BasvuruTarihi { get; set; }
        public int Boy { get; set; }

        public int Kilo { get; set; }
        public Enums.EnumCalismaDurumu CalismaDurumu{ get; set; }

        
        public Enums.EnumSgkDurumu SgkDurumu { get; set; }
        public Hasta Hasta { get; set; }
        public Doktor Doktor { get; set; }

        public Klinik Klinik { get; set; }

        public string Text
        {
            get
            {
                return $"Kayıt Zamanı:{KayitZamani}, Hasta : {Hasta.AdSoyad}, Basvuru No :{BasvuruNo},Basvuru Tarihi :{BasvuruTarihi},Klinik :{Klinik.Ad},Doktor :{Doktor.AdSoyad},Sgk Türü : {SgkDurumu},";
            }
        }
    }
}
