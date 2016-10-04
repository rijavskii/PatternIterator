using System.Collections.Generic;

namespace PatternIterator
{
    public class MyAgregate<TType>:IAgrigate<TType> where TType:class
    {
        private readonly List<TType> _item = new List<TType>();

        public IIterator<TType> CreateIterator()
        {
            return new MyIterator<TType>(this);
        }

        public int Count()
        {
            return _item.Count;
        }

        public void Add(TType entity)
        {
            _item.Add(entity);
        }
        public TType this[int index]
        {
            get { return _item[index]; }
            set { _item.Add(value); }
        }
    }
}