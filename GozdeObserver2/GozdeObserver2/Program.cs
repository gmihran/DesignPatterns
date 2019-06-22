using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeObserver2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Observer kullanılıyor....
            Console.Title = "Observer Tasarım Deseni";
            Product i1 = new Product();
            Gozlemleyici g1 = new Gozlemleyici { Bilgiler = "G. Mihran Altınsoy" };
            i1.GozlemleyiciEkle(g1);
            Gozlemleyici g2 = new Gozlemleyici { Bilgiler = "A. Burak İnner" };
            i1.GozlemleyiciEkle(g2);
            i1.Adi = "Aerius";
            i1.Turu = "Alerji";
            i1.Sekil = "Yuvarlak";
            i1.Miktar = 20;
            i1.Cesit = "Tablet";
            Console.WriteLine("Miktar güncelleniyor...");
            i1.MiktarGuncelleme = DateTime.Now;
            Console.WriteLine("İki gözlemciye de bildirim gitmektedir...\n");
            //MiktarGuncelleme metodu gözlemcilere bildirim yapmayı tetiklemektedir. Aynı zamanda değişikliğin olduğu zamanı tutmaktadır.

            Console.WriteLine("1. gözlemci Product listesinden kaldırılmıştır...\n");

            Console.WriteLine("Miktar güncelleniyor...");
            i1.GozlemleyiciSil(g1);
            i1.Miktar = 15;
            i1.MiktarGuncelleme = DateTime.Now;
            
            Console.WriteLine("1. gözlemci gözlemci listesinden kaldırıldığı için sadece 2. gözlemciye bildirim gitmektedir...");
            Console.ReadKey();
            //Observer kullanıldı....

        }
    }
}
