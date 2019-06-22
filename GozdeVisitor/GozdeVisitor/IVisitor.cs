using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeVisitor
{
    public interface IVisitor
    {
        void Visit(AgriKesici agriKesici);
    }
}
