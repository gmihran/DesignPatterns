using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeBuilder
{
    public abstract class IlacBuilder
    {
        protected Ilac _ilac;
        public Ilac ilac
        {
            get { return _ilac; }
        }
        public abstract void IlacPaketle();
        public abstract void IlacGrupla();
        public abstract void TuruBelirle();
        public abstract void MiktarBelirle();
    }
}
