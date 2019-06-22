using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeCOR
{
    abstract class CORHandler
    {
        protected CORHandler successor;
        public void Successor (CORHandler successor)
        {
            this.successor = successor;
        }
        public abstract void Istek(SatisYetkisi satisyetkisi);
    }

}
