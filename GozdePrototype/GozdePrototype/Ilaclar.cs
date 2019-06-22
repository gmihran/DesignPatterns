using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdePrototype
{
    public class Ilaclar : List<Ilac>
    {
        public void Liste()
        {
            foreach (var item in this)
                Console.WriteLine("İlacın Adı:{0} \tTürü:{1} \tŞekli:{2} \t Miktarı:{3} \t Çeşidi:{4} ", item.adi,item.turu,item.sekil,item.miktar,item.cesit);
        }
    }
}
