using System.Collections.Generic;

namespace DomainModels.Dtos
{
    public class RequestTagDto
    {
        public IList<ParentChildrenTagDto> Tags { get; set; } = new List<ParentChildrenTagDto>();
    }
}
