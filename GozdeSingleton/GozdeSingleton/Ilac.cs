using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeSingleton
{
    public class Ilac
    {
        static Ilac instance;

        public static Ilac Instance
        {
            get { return Ilac.instance; }
        }
        static Ilac()
        {
            instance = new Ilac();
        }

        string firma;

        public string Firma
        {
            get { return firma; }
            set { firma = value; }
        }
    }
}
