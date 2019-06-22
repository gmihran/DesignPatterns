using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    /// <summary>
    /// AğrıKesici abstract class
    /// </summary>
    public abstract class AgriKesici
    {
        public string Turu { get; set; }
        public AgriKesici(string turu)
        {
            Turu = turu;
        }
        public abstract void Accept(IVisitor visitor);
    }
}
