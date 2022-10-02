using Internship.Contracts.Entity;
using Internship.Service.Entity;
using Internship.Service.Implementations;

namespace Internship.Service.Interfaces
{
    public interface ITextService
    {
        public Task CreateText(TextModel textModel);
        Task CreateCVSAsync();
        Task SaveAsync();   
    }
}
