using Internship.Service.Entity;

namespace Internship.Service.Interfaces
{
    public interface ITextService
    {
        public Task CreateText(TextModel textModel);
        Task CreateCVSAsync();
    }
}
