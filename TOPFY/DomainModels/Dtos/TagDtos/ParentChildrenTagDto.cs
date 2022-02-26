using System.Collections.Generic;
using DomainModels.Dtos.TagDtos;
using DomainModels.Models;

namespace DomainModels.Dtos
{
   public class ParentChildrenTagDto
    {
        public int ParentTagId { get; set; }
        public string ParentTagName { get; set; }
        public ICollection<TagDto> ChildrenTags { get; set; }
    }
}
