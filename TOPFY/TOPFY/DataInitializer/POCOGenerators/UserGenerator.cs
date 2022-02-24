using System.Threading.Tasks;
using DomainModels.Models;
using Microsoft.AspNetCore.Identity;

namespace TOPFY.DataInitializer.POCOGenerators
{
    public class UserGenerator
    {
        public static async Task GenerateUsersAsync(UserManager<User>userManager)
        {
            //await userManager.CreateAsync(new User {UserName="Vahid"});
        }
    }
}
