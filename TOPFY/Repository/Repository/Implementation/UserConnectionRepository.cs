using DomainModels.Models;
using Microsoft.Extensions.Logging;
using Repository.DAL;
using Repository.Repository.Abstarction;
using Repository.Services.Implementation;

namespace Repository.Repository.Implementation
{
    public class UserConnectionRepository:GenericRepository<UserConnection>,IUserConnectionRepository
    {
        public UserConnectionRepository(AppDbContext dbConext,ILogger logger) : base(dbConext, logger) { }
    }
}
