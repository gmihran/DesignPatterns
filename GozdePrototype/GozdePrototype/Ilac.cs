using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdePrototype
{
    public class Ilac : ICloneable
    {
        public string adi { get; set; }
        public string turu { get; set; }
        public string sekil { get; set; }
        public int miktar { get; set; }
        public string cesit { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
