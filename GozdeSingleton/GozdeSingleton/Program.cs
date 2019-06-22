using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Singleton Tasarım Deseni";
            Ilac ilacim = Ilac.Instance;
            ilacim.Firma = "Health Group";
            Ilac ilacim2 = Ilac.Instance;
            Console.WriteLine(ilacim2.Firma);
            Console.ReadKey();

        }
    }
}
