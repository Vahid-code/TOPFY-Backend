using System.Collections.Generic;
using DomainModels.Models.Base;

namespace DomainModels.Models
{
    public class Tag:Entity
    {
        public string Name { get; set; }
        public Tag ParentTag { get; set; }
        public int PostCount { get; set; }
        public bool IsPopular { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
