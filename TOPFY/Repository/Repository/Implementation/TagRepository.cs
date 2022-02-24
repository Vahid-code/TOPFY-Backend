using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DomainModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.DAL;
using Repository.Repository.Abstarction;
using Repository.Services.Implementation;

namespace Repository.Repository.Implementation
{
   public class TagRepository:GenericRepository<Tag>,ITagRepository
    {
        public TagRepository(AppDbContext dbContext,ILogger logger) : base(dbContext, logger) { }
        public async Task<IList<Tag>> GetPopularTags(int numberOfTags)
        {
            return await dbSet.Where(t => !t.IsDeleted && t.IsPopular).Take(numberOfTags).ToListAsync();
        }

    }
}
