namespace _03.RangeException
{
    using System; 

    public class InvalidRangeException<T> : ApplicationException where T : IComparable<T>
    {
        public InvalidRangeException(string msg, T start, T end) : base(msg)
        {

        }

        public InvalidRangeException(string msg, T start, T end, Exception innerEx) : base(msg, innerEx)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; }
        public T End { get; }
    }
}
