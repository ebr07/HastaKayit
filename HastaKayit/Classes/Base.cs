using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_21HastaKayitEbruGozmen.Classes
{
    public class Base
    {
        public Base()
        {
            KayitZamani = DateTime.Now;
        }
        public DateTime KayitZamani { get; set; }
    }
}
