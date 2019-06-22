using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeAdapter
{
    public class Client
    {
        public void OdenecekTutarHesapla(ITutarHesaplayici hesaplayici)
        {
            Console.Write("Tutarı giriniz...:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adeti giriniz...:");
            double miktar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tutar:" + hesaplayici.Hesapla(fiyat, miktar));
        }
    }
}
