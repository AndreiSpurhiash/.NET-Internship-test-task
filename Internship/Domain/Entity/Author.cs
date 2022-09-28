using Internship.DAL.Interfaces;

namespace Internship.Domain.Entity
{
    public class Author : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
        public ICollection<Text> Texts { get; set; } = new List<Text>();

        public Author(Guid id, string firstName, string lastName, string nickName,
                      DateTime dateOfBirth, DateTime dateOfRegistration)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            DateOfBirth = dateOfBirth;
            DateOfRegistration = dateOfRegistration;
        }
    }
}
