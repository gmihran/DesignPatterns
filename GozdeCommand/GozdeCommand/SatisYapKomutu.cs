using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeCommand
{
    public class SatisYapKomutu : ICommand
    {
        private IlacIslemleri satisIslemleri;
        public SatisYapKomutu(IlacIslemleri satisIslemleri)
        {
            this.satisIslemleri = satisIslemleri;
        }
        public void Calistir()
        {
            satisIslemleri.SatisYap();
        }
    }
}
