namespace PatternIterator
{
    public class MyIterator<TEntity>:IIterator<TEntity> where TEntity:class
    {
        private readonly IAgrigate<TEntity> _agregate;
        private int _current;

        public MyIterator(IAgrigate<TEntity> agregate)
        {
            _agregate = agregate;
        }

        public TEntity First()
        {
            return _agregate[0];
        }

        public TEntity MoveNext()
        {
            _current++;
            return _current < _agregate.Count() ? _agregate[_current] : null ;
        }

        public bool IsDone() => _current >= _agregate.Count();


        public TEntity CurrentItem() => _agregate[_current];
        
    }
}