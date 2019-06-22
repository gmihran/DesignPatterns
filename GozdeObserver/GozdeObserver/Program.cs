using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("1-Miktar değişiyor...");

            product.MiktarDegis();
            //Burada gözlemci Product nesnesine eklenmediği için değişimle ilgili bir bildirim alınmıyor...

            //Değişim sonrasında notify edebilmek için ilgili gözlemci product nesnesine ekleniyor...
            product.GozlemciEkle(new CustomerObserver());

            Console.WriteLine("2-Miktar değişiyor...");

            // Ürün miktarı değişiyor...
            product.MiktarDegis();

            //Gözlemci product nesnesinden çıkarılıyor...
            product.GozlemciSil(new CustomerObserver());
            //Gözlemciyi silmek için GozlemciSil metodunu çalıştırmış olsam da miktar değiştiğinde bildirim geliyor.

            Console.WriteLine("3-Miktar değişiyor...");
            // Ürün miktarı değişiyor...
            product.MiktarDegis();
            //Gözlemci product nesnesinden çıkarıldığı için değişimle ilgili bir bildirim alınmıyor...

            Console.ReadKey();
        }
    }
}
