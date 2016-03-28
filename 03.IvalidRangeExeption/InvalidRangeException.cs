namespace _03.IvalidRangeExeption
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private const string ErrorMessage = "ERROR: The value is not in range";

        public InvalidRangeException(string message = ErrorMessage, Exception innerEx = null)
            : base(message, innerEx)
        {
        }

        public InvalidRangeException(T begin, T last, string message = ErrorMessage, Exception innerEx = null)
            : base(message, innerEx)
        {
            this.Start = begin;
            this.End = last;
        }

        public T Start { get; set; }

        public T End { get; set; }
    }
}
