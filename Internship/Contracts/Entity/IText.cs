using Internship.Cotracts.Entity;
using Internship.DAL.Interfaces;

namespace Internship.Contracts.Entity
{
    public interface IText : IEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string text { get; set; }
        DateTime DateOfCreation { get; set; }
        decimal Coast { get; set; }
        Guid AuthorId { get; set; }
        int NumberOfSales { get; set; }
    }
}
