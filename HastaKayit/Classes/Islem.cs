using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_21HastaKayitEbruGozmen.Classes
{
    public class Islem :Base , Interfaces.IText
    {
        public string Ad { get; set; }
        public string Kod { get; set; }

        public string Text
        {
            get
            {
                return $"Ad: {Ad}, Kod :{Kod}";
            }
        }

    }
}
