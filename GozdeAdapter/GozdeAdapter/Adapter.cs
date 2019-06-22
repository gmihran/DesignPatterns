using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeAdapter
{
    public class Adapter:ITutarHesaplayici
    {
        private Adaptee adaptee;
        public Adapter()
        {
            adaptee = new Adaptee();
        }
        public double Hesapla(double fiyat,double adet)
        {
            return adaptee.KDVliFiyatHesapla(fiyat,adet);
        }
            
    }
}
