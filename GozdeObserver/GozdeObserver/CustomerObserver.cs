using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeObserver
{
    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Takip edilen ilacın miktarı değişti.");
        }
    }
}
