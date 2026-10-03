using CommisionCalculator.Exception.ExceptionBase;
using System.Net;

namespace CommisionCalculator.Exception.InvalidInput
{
    public class InputInvalidException : CommisionException
    {
        private readonly List<string> _erros;
        public override int StatusCode => (int)HttpStatusCode.BadRequest;
        public InputInvalidException(List<string> errorMessages) : base(string.Empty)
        {
            _erros = errorMessages;
        }
        public override List<string> GetErros()
        {
            return _erros;
        }
    }
}
