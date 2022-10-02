using System.Net;

namespace Internship.Exceptions
{
    public class BadRequestException : PresentationException
    {
        public BadRequestException(string message)
            : base(HttpStatusCode.BadRequest, message)
        {
        }
    }
}
