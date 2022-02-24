using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModels.Models;
using Repository.Services.Abstarction;

namespace TOPFY.DataInitializer.POCOGenerators
{
    public class PostGenerator
    {
        public static async Task GeneratePostsAsync(IUnitOfWork _unitOfWork)
        {
            //await _unitOfWork.Posts.AddRangeAsync(new List<Post> { 
            //new Post{ }
            //});
        }
    }
}
