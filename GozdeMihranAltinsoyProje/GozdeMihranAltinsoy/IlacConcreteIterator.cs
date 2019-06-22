using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    //ConcreteIterator
    class IlacConcreteIterator : IIlacIterator
    {
        private IlacConcreteAggregate CollectionIlac;
        private int _index = 0;
        public IlacConcreteIterator(IlacConcreteAggregate ColIlac)
        {
            CollectionIlac = ColIlac;
        }
        public Ilac Next()
        {
            _index++;
            if (IsDone())
                return CollectionIlac.GetItem(_index);
            else
                return null;
        }
        public bool IsDone()
        {
            return _index < CollectionIlac.IlacMiktar;
        }
        public Ilac CurrentItem()
        {
            return CollectionIlac.GetItem(_index);
        }
        public Ilac First()
        {
            _index = 0;
            return CollectionIlac.GetItem(_index);
        }
    }
}
