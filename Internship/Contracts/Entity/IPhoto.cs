using Internship.Cotracts.Entity;
using Internship.DAL.Interfaces;

namespace Internship.Contracts.Entity
{
    public interface IPhoto : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Guid AuthorId { get; set; }
        public decimal Coast { get; set; }
        public int NumberOfSales { get; set; }
        public string OriginalSize { get; set; }
    }
}
