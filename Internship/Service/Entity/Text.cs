namespace Internship.Service.Entity
{
    public class Text
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string text { get; set; }
        public DateTime DateOfCreation { get; set; }
        public decimal Coast { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
        public int NumberOfSales { get; set; }
    }
}
