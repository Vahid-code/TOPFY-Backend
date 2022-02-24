using DomainModels.Models;
using Microsoft.Extensions.Logging;
using Repository.DAL;
using Repository.Repository.Abstarction;
using Repository.Services.Implementation;

namespace Repository.Repository.Implementation
{
   public class TagRepository:GenericRepository<Tag>,ITagRepository
    {
        public TagRepository(AppDbContext dbContext,ILogger logger) : base(dbContext, logger) { }
    }
}
