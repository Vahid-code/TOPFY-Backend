using System.Collections.Generic;
using DomainModels.Models.Base;

namespace DomainModels.Models
{
    public class Post:Entity
    {
        public string MainImage { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public string MainTagId { get; set; }
        public ICollection<Tag> SpecificTags { get; set; }
    }
}
