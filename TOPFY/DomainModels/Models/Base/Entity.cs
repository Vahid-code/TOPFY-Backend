using System;
using System.ComponentModel.DataAnnotations;

namespace DomainModels.Models.Base
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
