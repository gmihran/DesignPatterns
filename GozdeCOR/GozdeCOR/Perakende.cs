using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeCOR
{
    //ConcreteHandler
    class Perakende :CORHandler
    {
        public override void Istek(SatisYetkisi satisyetkisi)
        {
            if (satisyetkisi.Yetki == true && satisyetkisi.Adet <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} Ödeme Onaylandı...", this.GetType().Name);
            }
                
            else if (successor != null)
                successor.Istek(satisyetkisi);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} Ödeme Onaylanlanmadı...", this.GetType().Name);
            }
                
        }
    }
}
