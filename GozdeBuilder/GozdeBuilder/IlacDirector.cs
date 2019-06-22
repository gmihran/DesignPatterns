using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeBuilder
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
