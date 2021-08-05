using _2021_01_21HastaKayitEbruGozmen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_01_21HastaKayitEbruGozmen.Classes
{
    public static class Lists
    {
        public static List<Hasta> HastaList = new List<Hasta>();

        public static List<Doktor> DoktorList = new List<Doktor>();

        public static List<Basvuru> BasvuruList = new List<Basvuru>();

        public static List<string> Tani = new List<string>();

        public static List<Klinik> KlinikList = new List<Klinik>();

        public static List<Muayene> MuayeneList = new List<Muayene>();

        public static List<Tani> TaniList = new List<Tani>()
        {
         new Tani(){Ad ="A00",Kod ="Kolera"},
         new Tani(){Ad ="A01",Kod ="Tifo ve paratifo"},
         new Tani(){Ad ="A00",Kod ="Kolera"},
         new Tani(){Ad ="A16",Kod ="Solunum yolları tüberkülozu, bakteriyolojik ve histolojik olarak onaylanmamış"},
         new Tani(){Ad ="A37",Kod ="Boğmaca"},
         new Tani(){Ad ="A81",Kod ="Merkezi sinir sistemi yavaş virüs enfeksiyonları"},
         new Tani(){Ad ="C25",Kod ="Pankreas malign neoplazmı"},
         new Tani(){Ad ="V50",Kod ="Kamyonet veya van yolcusu yaralanması, yaya veya hayvanla çarpışmada"}
        };
       
        public static List<LaboratuvarTetkik> LaboratuvarTetkikList = new List<LaboratuvarTetkik>()
        {
          new LaboratuvarTetkik(){Ad ="Hemogram",Kod ="05"},
          new LaboratuvarTetkik(){Ad ="Biyokimya",Kod ="06"},
          new LaboratuvarTetkik(){Ad ="Eliza",Kod ="08"},
          new LaboratuvarTetkik(){Ad ="Hormon",Kod ="01"},
        };

        public static List<Islem> IslemList = new List<Islem>()
        {
            new Islem(){Ad ="Diş Çekimi",Kod ="001"},
            new Islem(){Ad ="Alçıya Alma",Kod ="002"},
            new Islem(){Ad ="Göz Muayenesi",Kod ="003"},
            new Islem(){Ad ="Ortopedik Muayene",Kod ="004"},
            new Islem(){Ad ="Enjeksiyon",Kod ="005"}
        };
    }
}
