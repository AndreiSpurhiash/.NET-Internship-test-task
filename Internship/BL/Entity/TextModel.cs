using Internship.Contracts.Entity;

namespace Internship.Service.Entity
{
    public class TextModel: IText
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string text { get; set; }
        public DateTime DateOfCreation { get; set; }
        public decimal Coast { get; set; }
        public AuthorModel Author { get; set; }
        public Guid AuthorId { get; set; }
        public int NumberOfSales { get; set; }
    }
}
