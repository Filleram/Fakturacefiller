using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakturacefiller
{
    public class Faktura

    {
        public int id { get; set; }
        public DateTime datum { get; set; }
        public int cislo { get; set; }
        public string odberatel { get; set; }
        public string nazev { get; set; }
        public int pocet { get; set; }
        public float cena1 { get; set; }
        public float cenacelkem { get; set; }
        public float DPH { get; set; }
        public float cenasDPH { get; set; }



    }
}