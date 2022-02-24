using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModels.Models;
using Repository.DAL;
using Repository.Services.Abstarction;

namespace TOPFY.DataInitializer.POCOGenerators
{
    public class TagGenerator
    {
        public static async Task GenerateTagsAsync(IUnitOfWork _unitOfWork)
        {
            await _unitOfWork.Tags.AddRangeAsync(new List<Tag> {
            new Tag{Name="Sport"},new Tag{Name="Travelling"},
            new Tag{Name="Reading"},new Tag{Name="Cooking"}
            });

            //Tag tag = await _unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Sport");
            //await _unitOfWork.Tags.AddRangeAsync(new List<Tag> {
            //new Tag{Name="Football",ParentTag=tag},new Tag{Name="Basketball",ParentTag=tag},
            //new Tag{Name="Volleyball",ParentTag=tag},new Tag{Name="Swimming",ParentTag=tag}
            //});

            //Tag tag2 = await _unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Cooking");
            //await _unitOfWork.Tags.AddRangeAsync(new List<Tag> {
            //new Tag{Name="Cookies",ParentTag=tag2},new Tag{Name="Pizza",ParentTag=tag2},
            //new Tag{Name="Spaghetti",ParentTag=tag2},new Tag{Name="Sushi",ParentTag=tag2}
            //});

            //Tag tag3 = await _unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Travelling");
            //await _unitOfWork.Tags.AddRangeAsync(new List<Tag> {
            //new Tag{Name="Hiking",ParentTag=tag3},new Tag{Name="Alpinism",ParentTag=tag3},
            //new Tag{Name="Fishing",ParentTag=tag3},new Tag{Name="Photography",ParentTag=tag3},
            //new Tag{Name="Camping",ParentTag=tag3}
            //});

        }
    }
}
