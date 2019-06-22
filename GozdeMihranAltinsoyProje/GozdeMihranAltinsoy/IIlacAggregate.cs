using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    //Aggregate arayüzü
    interface IIlacAggregate
    {
        IIlacIterator GetIterator();
    }
}

