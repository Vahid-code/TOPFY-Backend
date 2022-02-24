using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModels.Models;
using Microsoft.AspNetCore.Identity;
using Repository.Services.Abstarction;

namespace TOPFY.DataInitializer.POCOGenerators
{
    public class UserGenerator
    {
        public static async Task GenerateUsersAsync(UserManager<User>userManager,IUnitOfWork unitOfWork)
        {
            Tag sportTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Sport");
            Tag cookingTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Cooking");
            Tag travellingTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Travelling");
            Tag pizzaTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Pizza");
            Tag photographyTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Photography");
            Tag footballTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Football");
            Tag swimmingTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Swimming");
            await userManager.CreateAsync(new User
            { UserName = "vahid", Email = "vahid@gmail.com", Tags = new List<Tag> { sportTag, cookingTag } });
            await userManager.CreateAsync(new User
            { UserName = "nihad", Email = "nihad@gmail.com", Tags = new List<Tag> { travellingTag } });
            await userManager.CreateAsync(new User
            { UserName = "vasif", Email = "vasif@gmail.com", Tags = new List<Tag> { travellingTag } });
            await userManager.CreateAsync(new User
            {
                UserName = "nurlan",
                Email = "nurlan@gmail.com",
                Tags = new List<Tag> { sportTag, swimmingTag }
            });
            await userManager.CreateAsync(new User
            { UserName = "musa", Email = "musa@gmail.com", Tags = new List<Tag> { sportTag, footballTag } });
            await userManager.CreateAsync(new User
            {
                UserName = "musaPizza",
                Email = "musaPizza@gmail.com",
                Tags =
            new List<Tag> { cookingTag, pizzaTag }
            });
            await userManager.CreateAsync(new User
            {
                UserName = "vahidPhotography",
                Email = "vahidPhotography@gmail.com",
                Tags = new List<Tag> { photographyTag }
            });
            await userManager.CreateAsync(new User
            {
                UserName = "vahidCook",
                Email = "vahidCook@gmail.com",
                Tags = new List<Tag> { cookingTag }
            });
        }
    }
    
}
