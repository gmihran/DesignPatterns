using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    public class IlacConcrete2 : IlacBuilder
    {
        public IlacConcrete2()
        {
            _ilac = new Ilac { Adi = "İburamin" };
        }
        public override void IlacGrupla()
        {
            _ilac.Cesit = "Şurup";
        }

        public override void IlacPaketle()
        {
            _ilac.Sekil = "Sıvı";
        }
        public override void TuruBelirle()
        {
            _ilac.Turu = "Öksürük";
        }
        public override void MiktarBelirle()
        {
            _ilac.Miktar = 50;
            //50 mg
        }
    }
}
