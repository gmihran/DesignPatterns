using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Builder Tasarım Deseni";
            IlacBuilder ilac_builder = new IlacConcrete1();
            IlacDirector ilac_olusturucu = new IlacDirector(ilac_builder);
            Console.WriteLine(ilac_builder.ilac.ToString());

            ilac_builder = new IlacConcrete2();
            ilac_olusturucu = new IlacDirector(ilac_builder);
            Console.WriteLine(ilac_builder.ilac.ToString());

            Console.ReadKey();
        }
    }
}
