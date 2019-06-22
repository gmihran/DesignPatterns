using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GozdeMihranAltinsoy
{
    class Factory
    {
        private static int _PoolMaxSize = 3;

        private static readonly Queue objPool = new Queue(_PoolMaxSize);
        public Ilacim GetIlac()
        {
            Ilacim oIlac;

            if (Ilacim.ObjectCounter >= _PoolMaxSize && objPool.Count > 0)
            {

                oIlac = RetrieveFromPool();
            }
            else
            {
                oIlac = GetYeniIlac();
            }
            return oIlac;
        }
        private Ilacim GetYeniIlac()
        {

            Ilacim oIlac2 = new Ilacim();
            objPool.Enqueue(oIlac2);
            return oIlac2;
        }
        protected Ilacim RetrieveFromPool()
        {
            Ilacim oIlac2;

            if (objPool.Count > 0)
            {
                oIlac2 = (Ilacim)objPool.Dequeue();
                Ilacim.ObjectCounter--;
            }
            else
            {
                oIlac2 = new Ilacim();
            }
            return oIlac2;
        }
    }
}
