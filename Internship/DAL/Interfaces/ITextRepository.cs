using Internship.Domain.Entity;

namespace Internship.DAL.Interfaces
{
    public interface ITextRepository
    {
        void Create(Text text);
        void Save(Text text);
    }
}
