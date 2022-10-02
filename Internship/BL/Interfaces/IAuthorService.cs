using Internship.Migrations;
using Internship.Service.Entity;

namespace Internship.Service.Interfaces
{
    public interface IAuthorService
    {
        public IEnumerable<string> GetEntitiesList();
    }
}
