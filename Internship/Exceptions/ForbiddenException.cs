using System.Net;

namespace Internship.Exceptions
{
    public class ForbiddenException : PresentationException
    {
        public ForbiddenException(string message)
            : base(HttpStatusCode.Forbidden, message)
        {
        }
    }
}
