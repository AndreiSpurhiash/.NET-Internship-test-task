namespace Internship.Service.Entity
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
        public decimal Coast { get; set; }
        public int NumberOfSales { get; set; }
        public double Raiting { get; set; }
        public string OriginalSize { get; set; }
    }
}
