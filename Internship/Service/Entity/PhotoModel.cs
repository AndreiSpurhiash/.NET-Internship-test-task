using Internship.Contracts.Entity;

namespace Internship.Service.Entity
{
    public class PhotoModel: IPhoto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public DateTime DateOfCreation { get; set; }
        public AuthorModel Author { get; set; }
        public Guid AuthorId { get; set; }
        public decimal Coast { get; set; }
        public int NumberOfSales { get; set; }
        public double Raiting { get; set; }
        public string OriginalSize { get; set; }
    }
}
