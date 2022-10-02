using Internship.DAL.Interfaces;

namespace Internship.Domain.Entity
{
    public class Photo : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
        public decimal Coast { get; set; }
        public int NumberOfSales { get; set; }
        public string OriginalSize { get; set; }
        public int NumberOfRaiting { get; set; }
        public int AmountOfRaiting { get; set; }

        public Photo(string name, string link, DateTime dateOfCreation, Guid authorId,
            decimal coast, int numberOfSales, string originalSize)
        {
            Id = Guid.NewGuid();
            Name = name;
            Link = link;
            AuthorId = authorId;
            DateOfCreation = dateOfCreation;
            Coast = coast;
            NumberOfSales = numberOfSales;
            OriginalSize = originalSize;
        }
    }
}
