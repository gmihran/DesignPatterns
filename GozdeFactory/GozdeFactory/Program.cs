using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            //Factory kullanılıyor...
            //Bu uygulamada Interface İle Factory Method Design Pattern kullanılmıştır.
            //Abstract Class İle Factory Method Design Pattern ile aynı uygulama gerçekleştirilebilir.
            Console.Title = "Factory Tasarım Deseni";
            Krem krem = new Krem();
            Surup surup = new Surup();
            Tablet tablet = new Tablet();

            krem.IlacCesitleri();
            surup.IlacCesitleri();
            tablet.IlacCesitleri();
            Console.ReadKey();

            //Factory kullanıldı...
        }
    }
}
