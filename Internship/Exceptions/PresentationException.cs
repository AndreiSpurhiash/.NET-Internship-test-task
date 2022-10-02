using System.Net;

namespace Internship.Exceptions
{
    public class PresentationException : Exception
    {
        public PresentationException(
            HttpStatusCode statusCode,
            string message)
        : base(message)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; }
    }
}
