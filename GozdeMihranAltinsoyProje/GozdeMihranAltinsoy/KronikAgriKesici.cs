using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    /// <summary>
    /// ConcreteElement class
    /// </summary>
    public class KronikAgriKesici : AgriKesici
    {
        public KronikAgriKesici(string turu)
            : base(turu)
        {

        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
