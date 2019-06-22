using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    public class KomutIletici
    {
        public void Calistir(ICommand komut)
        {
            komut.Calistir();
        }
    }
}
