using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeIterator
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            //Iterator kullanılıyor...
            Console.Title = "Iterator Tasarım Deseni";
            IlacConcreteAggregate IlacCollection = new IlacConcreteAggregate();
            IlacCollection.Add(new Ilac { Adi = "Majezik", Miktar = 20 });
            IlacCollection.Add(new Ilac { Adi = "Aferin", Miktar = 15 });
            IlacCollection.Add(new Ilac { Adi = "Augmentin", Miktar = 14 });
            IIlacIterator itr = IlacCollection.GetIterator();
            while (itr.IsDone())
            {
                Console.WriteLine("{0}:{1}", itr.CurrentItem().Adi, itr.CurrentItem().Miktar);
                itr.Next();
            }
            //First metodu ile ilk değere dönüldü.
            Console.WriteLine("\nİlk değer ekrana yazdırılıyor...");
            Ilac ilac= itr.First();
            Console.WriteLine("{0}:{1}", itr.CurrentItem().Adi, itr.CurrentItem().Miktar);
            Console.WriteLine("\nİlk değerin miktarı ekrana yazdırılıyor...");
            Console.WriteLine("Miktar:" + ilac.Miktar.ToString());
            Console.ReadKey();

            //Iterator kullanıldı...
        }
    }
    
}
