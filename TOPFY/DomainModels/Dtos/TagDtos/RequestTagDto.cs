using System.Collections.Generic;

namespace DomainModels.Dtos
{
    public class RequestTagDto
    {
        public ICollection<ParentChildrenTagDto> Tags { get; set; } = new List<ParentChildrenTagDto>();
    }
}
