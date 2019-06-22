using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeObjectPool
{
    class Ilacim
    {
        public static int ObjectCounter = 0;
        public Ilacim()
        {
            ++ObjectCounter;
        }
        private string _Adi;
        private string _Turu;
        private int _Miktar;
        private string _Sekil;
        private string _Cesit;


        public string Adi
        {
            get
            {
                return _Adi;
            }
            set
            {
                _Adi = value;
            }
        }

        public string Turu
        {
            get
            {
                return _Turu;
            }
            set
            {
                _Turu = value;
            }
        }

        public string Sekil
        {
            get
            {
                return _Sekil;
            }
            set
            {
                _Sekil = value;
            }
        }

        public int Miktar
        {
            get
            {
                return _Miktar;
            }
            set
            {
                _Miktar = value;
            }
        }
        public string Cesit
        {
            get
            {
                return _Cesit;
            }
            set
            {
                _Cesit = value;
            }
        }
    }
}

