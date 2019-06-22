using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    /// <summary>
    /// ConcreteVisitor class
    /// </summary>
    class KronikVisitor : IVisitor
    {
        public void Visit(AgriKesici agriKesici)
        {
            if (agriKesici is AkutAgriKesici)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Akut Ağrı Kesici Kronik ağrınızı kesmeyecektir...");
            }
            else if (agriKesici is KronikAgriKesici)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Kronik Ağrı Kesici Kronik ağrınızı kesececektir...");
            }

            else
                Console.WriteLine("Bu ilaç ağrı kesici değildir...");

        }
    }
}
