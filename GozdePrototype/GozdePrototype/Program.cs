using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "Prototype Tasarım Deseni";
            //Bu örnekte Prototype Tasarım Deseni ile Deep Copy Gerçekleştirilmiştir.

            Ilac prototip = new Ilac();
            prototip.adi = "Apranax";
            prototip.turu = "Ağrı kesici";
            prototip.sekil = "Dikdörtgen";
            prototip.miktar = 20;
            prototip.cesit = "Tablet";

            Ilac majezik = (Ilac)prototip.Clone();
            majezik.adi = "Majezik";

            Ilac parol = (Ilac)prototip.Clone();
            parol.adi = "Parol";

            Ilac vermidon = (Ilac)prototip.Clone();
            vermidon.adi = "Vermidon";

            Ilac nurofen = (Ilac)prototip.Clone();
            nurofen.adi = "Nurofen";

            Ilac aspirin = (Ilac)prototip.Clone();
            aspirin.adi = "Aspirin";

            Ilaclar ilaclar = new Ilaclar
            {
                majezik,
                parol,
                vermidon,
                nurofen,
                aspirin
            };
            ilaclar.Liste();

            majezik.miktar = 15;
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Majezik miktarı güncellenecektir.");
            Console.Write("Lütfen Majezik İlacının Miktarını Giriniz:");
            int miktar = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Majezik Miktarı güncelleniyor...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Majezik Miktarı güncellendi...");
            Console.Clear();

            majezik.miktar = miktar;

            Console.WriteLine("İlaçlar tekrar yazdırılıyor...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            ilaclar.Liste();
            Console.ReadKey();
        }
    }
}
