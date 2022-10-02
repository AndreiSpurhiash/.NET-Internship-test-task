using Internship.Contracts.Entity;
using Internship.Service.Entity;

namespace Internship.Service.Interfaces
{
    public interface ITextService
    {
        public Task CreateText(IText textModel);
        Task CreateCVSAsync();
    }
}
