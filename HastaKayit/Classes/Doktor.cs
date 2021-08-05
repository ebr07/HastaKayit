using _2021_01_21HastaKayitEbruGozmen.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_21HastaKayitEbruGozmen.Classes
{
    public class Doktor : Kisi , Interfaces.IText 
    { 
        public Enums.EnumBrans Brans { get; set; }
        public int MezuniyetYili { get; set; }
        public string MezunOlduguOkul { get; set; }

        public Enums.EnumUzmanlikDurumu UzmanlikDurumu { get; set; }

        public string Text
        {
            get
            {
                return $"TC Kimlik No :{TCKNo},Ad Soyad : {AdSoyad},Doğum Tarihi :{DogumTarihi},Telefon :{TelefonNo},Kan Grubu : {KanGrubu}, Brans :{Brans},Uzmanlık Durumu : {UzmanlikDurumu},Adres :{Adres}";
            }
        }
    }
}
