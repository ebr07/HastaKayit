using _2021_01_21HastaKayitEbruGozmen.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_21HastaKayitEbruGozmen.Classes
{
    public class Hasta : Kisi, Interfaces.IText
    {
        public string KritikRahatsizliklar { get; set; }
        public string SurekliKullandigiIlaclar { get; set; }
        public string Text
        {
            get 
            {
                return $"Kayıt Zamanı:{KayitZamani}, TC Kimlik No :{TCKNo},Ad Soyad : {AdSoyad},Doğum Tarihi :{DogumTarihi},Telefon :{TelefonNo},Kan Grubu : {KanGrubu},Meslek : {Meslek},Adres :{Adres}";
            }
        }
    }
}
