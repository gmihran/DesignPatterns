using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeVisitor
{
    class AkutVisitor : IVisitor
    {
        public void Visit(AgriKesici agriKesici)
        {
            if (agriKesici is AkutAgriKesici)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Akut Ağrı Kesici Akut ağrınızı kesecektir...");
            }
                
            else if (agriKesici is KronikAgriKesici)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kronik Ağrı Kesici Akut ağrınızı kesmeyecektir...");
            }
                
            else
                Console.WriteLine("Bu ilaç ağrı kesici değildir...");

        }
    }
}
