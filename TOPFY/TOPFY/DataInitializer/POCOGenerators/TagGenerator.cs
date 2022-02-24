using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModels.Models;
using Repository.Services.Abstarction;

namespace TOPFY.DataInitializer.POCOGenerators
{
    public class TagGenerator
    {

        public static async Task GenerateTagsAsync(IUnitOfWork _unitOfWork)
        {
            await _unitOfWork.Tags.AddRangeAsync(new List<Tag> {
            new Tag{Name="Sport"},new Tag{Name="Blogging"},
            new Tag{Name="Reading"},new Tag{Name="Camping"},
            new Tag{Name="Cooking"}
            });
            Tag tag = await _unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Sport");
            await _unitOfWork.Tags.AddRangeAsync(new List<Tag> {
            new Tag{Name="Football",ParentTag=tag},new Tag{Name="Basketball",ParentTag=tag},
            new Tag{Name="Volleyball",ParentTag=tag},new Tag{Name="Tennis",ParentTag=tag}
            });
            Tag tag2 = await _unitOfWork.Tags.FirstOrDefaultAsync(t => t.Name == "Cooking");
            await _unitOfWork.Tags.AddRangeAsync(new List<Tag> {
            new Tag{Name="Cookies",ParentTag=tag2},new Tag{Name="Pizza",ParentTag=tag2},
            new Tag{Name="Spaghetti",ParentTag=tag2},new Tag{Name="Sushi",ParentTag=tag2}
            });
        }
    }
}
