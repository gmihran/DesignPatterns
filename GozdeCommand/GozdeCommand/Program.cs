using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command Kullanılıyor...

            Console.Title = "Command Tasarım Deseni";
            SatisYapKomutu satisYapKomutu = new SatisYapKomutu(new IlacIslemleri());
            IlacPaketleKomutu ilacPaketleKomutu = new IlacPaketleKomutu(new IlacIslemleri());

            KomutIletici iletici = new KomutIletici();


            iletici.Calistir(satisYapKomutu);
            iletici.Calistir(ilacPaketleKomutu);

            Console.ReadKey();

            //Command Kullanıldı...

        }
    }
}
