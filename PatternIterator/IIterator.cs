namespace PatternIterator
{
    public interface IIterator<TEntity> 
    {
        TEntity First();
        TEntity MoveNext();
        bool IsDone();
        TEntity CurrentItem();
    }
}