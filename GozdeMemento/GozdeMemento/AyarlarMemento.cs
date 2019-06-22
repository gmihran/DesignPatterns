using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMemento
{
    public class AyarlarMemento
    {
        //Asıl nesnemizin alanlarını tutan memento sınıfımız tanımlanıyor...

        public string Adi { get; set; }
        public string Turu { get; set; }
        public string Sekil { get; set; }
        public int Miktar { get; set; }
        public string Cesit { get; set; }
    }
}
