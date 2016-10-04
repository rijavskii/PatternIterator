namespace PatternIterator
{
    public interface IAgrigate<TType>
    {
        IIterator<TType> CreateIterator();
        int Count();
        TType this[int index] { get; set; }
        void Add(TType car);
    }
}