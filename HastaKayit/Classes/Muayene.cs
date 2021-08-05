using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_21HastaKayitEbruGozmen.Classes
{
    public class Muayene : Base, Interfaces.IText
    {
        public Basvuru Basvuru { get; set; }
        public DateTime MuayeneZamani { get; set; }
        public string Tani { get; set; }

        public string Islem { get; set; }
        public string LaboratuvarTetkikleri { get; set; }

        public string Text
        {
            get
            {
                return $"Kayıt Zamanı:{KayitZamani}, Başvuru No :{Basvuru.BasvuruNo},Hasta : {Basvuru.Hasta.AdSoyad} Muayene Zamanı :{MuayeneZamani},Tanılar : {Tani},Yapılan İşlemler :{Islem},Laboratuvar : {LaboratuvarTetkikleri}";
            }
        }
    }
}
