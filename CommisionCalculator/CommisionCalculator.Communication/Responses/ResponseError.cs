namespace CommisionCalculator.Communication.Responses
{
    public class ResponseError
    {
        public List<string> Errors { get; set; }
        public ResponseError(List<string> errors) => Errors = errors;
    }
}
