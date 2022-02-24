using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DomainModels.Models;
using Repository.Services.Abstarction;
namespace Repository.Repository.Abstarction
{
   public interface IPostRepository:IGenericRepository<Post>
    {
       
    }
}
