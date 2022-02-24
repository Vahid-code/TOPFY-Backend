using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace DomainModels.Models
{
    public class User : IdentityUser
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Image { get; set; }
        public bool IsContributer { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
