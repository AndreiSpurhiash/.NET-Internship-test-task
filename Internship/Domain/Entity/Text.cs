using Internship.DAL.Interfaces;

namespace Internship.Domain.Entity
{
    public class Text : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string text { get; set; }
        public DateTime DateOfCreation { get; set; }
        public decimal Coast { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
        public int NumberOfSales { get; set; }

        public Text(string name, string text, DateTime dateOfCreation, decimal coast, int numberOfSales)
        {
            Id = Guid.NewGuid();
            Name = name;
            this.text = text;
            DateOfCreation = dateOfCreation;
            Coast = coast;
            NumberOfSales = numberOfSales;
        }
    }
}
