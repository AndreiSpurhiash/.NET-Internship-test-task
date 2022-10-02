using System.Net;

namespace Internship.Exceptions
{
    public class NotFoundException : PresentationException
    {
        public NotFoundException(string message)
            : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}
