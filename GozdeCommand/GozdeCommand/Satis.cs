using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeCommand
{
    public class Satis
    {
        string firmaAdi;
        string ilacAdi;
        int adet;

        public string FirmaAdi
        {
            get { return firmaAdi; }
            set { firmaAdi = value; }
        }
        public string IlacAdi
        {
            get { return ilacAdi; }
            set { ilacAdi = value; }
        }
        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }
    }
}
