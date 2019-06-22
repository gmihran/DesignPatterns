using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    public class IlacDirector
    {
        public IlacDirector(IlacBuilder IlacConcrete)
        {
            IlacConcrete.IlacGrupla();
            IlacConcrete.IlacPaketle();
            IlacConcrete.TuruBelirle();
            IlacConcrete.MiktarBelirle();
        }
    }
}
