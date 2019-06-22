using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeAdapter
{
    public class IlacCesidineGoreHesapla : ITutarHesaplayici
    {
        public double Hesapla(double fiyat,double adet)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("İlaç Tipini Seçiniz:");
            Console.WriteLine("1-Şurup-KDV:%1.05");
            Console.WriteLine("2-Krem-KDV:%1.02");
            Console.WriteLine("3-Tablet-KDV:%1.3");
            Console.WriteLine("Diğer Ürünler-KDV:%2.5");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Diğer ürünler seçimi için 1-2-3 dışındaki sayısal bir değeri giriniz...");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Seçiminiz...:");
            int secim = Convert.ToInt16(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (secim == 1)
                return fiyat * adet * 1.05;
            else if (secim == 2)
                return fiyat * adet * 1.02;
            else if (secim==3)
                return fiyat * adet * 1.3;
            else
                return fiyat * adet * 2.5;
        }
    }
}
