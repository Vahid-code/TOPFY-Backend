using DomainModels.Models.Base;

namespace DomainModels.Models
{
   public class UserConnection:Entity
    {
        public User User { get; set; }
        public User FollowerId {get; set; }
    }
}
