using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DomainModels.Models;
using Microsoft.Extensions.Logging;
using Repository.DAL;
using Repository.Repository.Abstarction;
using Repository.Services.Implementation;

namespace Repository.Repository.Implementation
{
   public class PostRepository:GenericRepository<Post>,IPostRepository
    {
        public PostRepository(AppDbContext dbContext,ILogger logger):base(dbContext,logger)
        {

        }
    }
}
