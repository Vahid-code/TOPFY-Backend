using System;

namespace DomainModels.Models.Base
{
    public interface IEntity
    {
        string Id { get; set; }
        DateTime StartDate { get; set; }
        DateTime DeletedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
