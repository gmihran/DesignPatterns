using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeBuilder
{
    public class IlacConcrete1 : IlacBuilder
    {
        public IlacConcrete1()
        {
            _ilac = new Ilac { Adi = "Majezik" };
        }
        public override void IlacGrupla()
        {
            _ilac.Cesit = "Tablet";
        }

        public override void IlacPaketle()
        {
            _ilac.Sekil = "Yuvarlak";
        }
        public override void TuruBelirle()
        {
            _ilac.Turu = "Ağrı";
        }
        public override void MiktarBelirle()
        {
            _ilac.Miktar = 20;
            //20 adet
        }
    }
}
