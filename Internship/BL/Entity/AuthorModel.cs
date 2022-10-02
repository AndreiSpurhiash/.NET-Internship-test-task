using Internship.Contracts.Entity;
using Internship.Cotracts.Entity;

namespace Internship.Service.Entity
{
    public class AuthorModel: IAuthor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}
