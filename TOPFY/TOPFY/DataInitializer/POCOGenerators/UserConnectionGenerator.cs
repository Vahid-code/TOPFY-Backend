using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModels.Models;
using Repository.Services.Abstarction;

namespace TOPFY.DataInitializer.POCOGenerators
{
    public class UserConnectionGenerator
    {
        public static async Task GenerateUserConnectionsAsync(IUnitOfWork _unitOfWork)
        {
            //await _unitOfWork.UserConnections.AddRangeAsync(new List<UserConnection>{
            //    new UserConnection { }
            //});
        }
    }
}
