using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeAdapter
{
    public class Adaptee
    {
        public double KDVliFiyatHesapla(double fiyat,double adet)
        {
            double kdv;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Kdv değerini giriniz...:");
                kdv = Convert.ToDouble(Console.ReadLine()); 
                if (kdv<=0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kdv değeri sıfır ve negatif değer olamaz. Tekrar deneyiniz.");
                }
                    
            } while (kdv <= 0);
            Console.ForegroundColor = ConsoleColor.Green;
            return fiyat * adet + fiyat * adet * kdv;
        }
    }
}
