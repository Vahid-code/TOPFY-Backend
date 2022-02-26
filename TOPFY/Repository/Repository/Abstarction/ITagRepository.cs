using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModels.Models;
using Repository.Services.Abstarction;

namespace Repository.Repository.Abstarction
{
    public interface ITagRepository:IGenericRepository<Tag>
    {
        public Task<IList<Tag>> GetPopularTags(int numberOfTags);
    }
}
