using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModels.Models;
using Microsoft.AspNetCore.Identity;
using Repository.Services.Abstarction;

namespace TOPFY.DataInitializer.POCOGenerators
{
    public class PostGenerator
    {
        public static async Task GeneratePostsAsync(IUnitOfWork unitOfWork,UserManager<User> userManager)
        {
            Tag sportTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Sport");
            Tag cookingTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Cooking");
            Tag travellingTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Travelling");
            Tag pizzaTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Pizza");
            Tag photographyTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Photography");
            Tag footballTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Football");
            Tag swimmingTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Swimming");
            Tag PizzaTag = await unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Pizza");

            User musaUser = await userManager.FindByNameAsync("musa"); //sportTag, footballTag
            User vahid = await userManager.FindByNameAsync("vahid"); // sportTag, cookingTag
            User nihad = await userManager.FindByNameAsync("nihad"); // travellingTag
            User vasif = await userManager.FindByNameAsync("vasif"); // travellingTag
            User nurlan = await userManager.FindByNameAsync("nurlan"); // sportTag, swimmingTag
            User vahidPhotography = await userManager.FindByNameAsync("vahidPhotography"); // photographyTag
            User vahidCook = await userManager.FindByNameAsync("vahidCook"); // cookingTag

            await unitOfWork.Posts.AddRangeAsync(new List<Post> {

                  // Musa User (11) sportTag, footballTag
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer2" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer3" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer4" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer5" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer6" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer7" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer8" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer9" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer10" },
            new Post{ User=musaUser,MainTagId=sportTag.Id,SpecificTags=
            new List<Tag>{footballTag},Description="Dummy Description",MainImage="sportSoccer11" },

              // Vahid User  (10) sportTag, cookingTag
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza1" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza2" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza3" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza4" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza5" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza6" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza7" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza8" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza9" },
            new Post{ User=vahid,MainTagId=cookingTag.Id,SpecificTags=
             new List<Tag>(){PizzaTag},Description="Dummy Description",MainImage="Pizza10" },

                // Nihad User (6) travellingTag
            new Post
            {
                User = nihad,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling"
            },
            new Post
            {
                User = nihad,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling"
            },
            new Post
            {
                User = nihad,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling2"
            },
            new Post
            {
                User = nihad,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travellin3"
            },
            new Post
            {
                User = nihad,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling4"
            },
            new Post
            {
                User = nihad,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling5"
            },

                 // vasif User (5) travellingTag

            new Post
            {
                User = vasif,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling6"
            },
            new Post
            {
                User = vasif,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling7"
            },
            new Post
            {
                User = vasif,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling8"
            },
            new Post
            {
                User = vasif,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling9"
            },
            new Post
            {
                User = vasif,
                MainTagId = travellingTag.Id,
                Description = "Dummy Description",
                MainImage = "travelling10"
            },

               //Nurlan User (14) sportTag, swimmingTag
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                Description = "Dummy Description",
                MainImage = "sport"
            }, 
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                Description = "Dummy Description",
                MainImage = "sport"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                Description = "Dummy Description",
                MainImage = "sport2"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                Description = "Dummy Description",
                MainImage = "sport3"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming2"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming3"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming4"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming5"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming6"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming7"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming8"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming9"
            },
            new Post
            {
                User = nurlan,
                MainTagId = sportTag.Id,
                SpecificTags=new List<Tag>{swimmingTag},
                Description = "Dummy Description",
                MainImage = "sportSwimming10"
            },

            //vahidPhotography (10) photographyTag
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography1"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography2"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography3"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography4"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography5"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography6"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography7"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography8"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography9"
            },
            new Post
            {
                User = vahidPhotography,
                MainTagId = photographyTag.Id,
                Description = "Dummy Description",
                MainImage = "photography10"
            },

            //vahidCook (10)  cookingTag
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking1"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking2"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking3"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking4"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking5"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking6"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking7"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking8"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking9"
            },
            new Post
            {
                User = vahidCook,
                MainTagId = cookingTag.Id,
                Description = "Dummy Description",
                MainImage = "cooking10"
            },
            });


        }
    }
}
