namespace CommisionCalculator.Exception.ExceptionBase
{
    public abstract class CommisionException : SystemException
    {
        protected CommisionException(string message): base(message) { }
        public abstract int StatusCode { get; }
        public abstract List<string> GetErros();
    }
}
