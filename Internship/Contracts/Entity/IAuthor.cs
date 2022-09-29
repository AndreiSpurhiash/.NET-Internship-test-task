using Internship.Contracts.Entity;
using Internship.DAL.Interfaces;

namespace Internship.Cotracts.Entity
{
    public interface IAuthor : IEntity
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string NickName { get; set; }
        DateTime DateOfBirth { get; set; }
        DateTime DateOfRegistration { get; set; }
    }
}
