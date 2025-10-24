public class InvalidRangeException<T> : Exception
{
    private const string ErrorMessage = "ERROR: The value is not in range";
    public InvalidRangeException(string message = ErrorMessage, Exception innerEx = null)
        : base(message, innerEx)
    {        
    }

    public InvalidRangeException(T begin, T end, string message = ErrorMessage, Exception innerEx = null)
        : base(message, innerEx)
    {
        Begin = begin;
        End = end;
    }

    public T Begin { get; private set; }
    public T End { get; private set; }
}
