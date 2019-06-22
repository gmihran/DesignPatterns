using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Pool kullanılıyor...
            Console.Title = "Object Pool Tasarım Deseni";
            Factory fa = new Factory();
            Ilacim Ilac1 = fa.GetIlac();
            Console.WriteLine("1. ilaç");
            Ilacim Ilac2 = fa.GetIlac();
            Console.WriteLine("2. ilaç");
            Ilacim Ilac3 = fa.GetIlac();
            Console.WriteLine("3. ilaç");
            Console.ReadKey();
            //Object Pool kullanıldı...
        }
    }
}
