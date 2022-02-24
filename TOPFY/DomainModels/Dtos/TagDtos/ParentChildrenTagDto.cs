using System.Collections.Generic;
using DomainModels.Dtos.TagDtos;
using DomainModels.Models;

namespace DomainModels.Dtos
{
   public class ParentChildrenTagDto
    {
        public TagDto ParentTag { get; set; }
        public ICollection<TagDto> ChildrenTags { get; set; }
    }
}
