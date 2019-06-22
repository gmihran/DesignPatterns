using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    class IlacPaketleKomutu : ICommand
    {
        private IlacIslemleri satisIslemleri;
        public IlacPaketleKomutu(IlacIslemleri satisIslemleri)
        {
            this.satisIslemleri = satisIslemleri;
        }
        public void Calistir()
        {
            satisIslemleri.IlacPaketle();
        }
    }
}
