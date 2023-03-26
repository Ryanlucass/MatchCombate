namespace Domain.ViewModel
{
    public class ErrorDetails
    {
        public string Logref { get; private set; }
        public string Message { get; private set; }

        public ErrorDetails(string logref, string message)
        {
            Logref = logref;
            Message = message;
        }

    }
}
