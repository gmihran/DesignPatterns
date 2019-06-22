using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    //ConcreteAggregate
    class IlacConcreteAggregate : IIlacAggregate
    {
        private List<Ilac> _IlacList = new List<Ilac>();
        public int IlacMiktar { get { return _IlacList.Count; } }
        public void Add(Ilac t)
        {
            _IlacList.Add(t);
        }
        public Ilac GetItem(int index)
        {
            return _IlacList[index];
        }
        public IIlacIterator GetIterator()
        {
            return new IlacConcreteIterator(this);
        }
    }
}
