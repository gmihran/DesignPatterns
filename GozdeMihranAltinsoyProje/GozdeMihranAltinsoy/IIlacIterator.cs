using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    //Iterator arayüzü
    interface IIlacIterator
    {
        Ilac First();
        Ilac Next();
        bool IsDone();
        Ilac CurrentItem();
    }
}
