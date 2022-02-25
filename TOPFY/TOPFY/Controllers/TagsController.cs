using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DomainModels.Dtos;
using DomainModels.Dtos.TagDtos;
using DomainModels.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Services.Abstarction;

namespace TOPFY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TagsController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> GetPopularTags([FromQuery]int count)
        {
            IEnumerable<Tag> popularTags = await _unitOfWork.Tags.GetPopularTags(count);
            RequestTagDto dto = new();
            foreach (Tag tag in popularTags)
            {
                ICollection<Tag> childTags = await _unitOfWork.Tags
                    .FindAllAsync(t => t.ParentTag == tag&&!t.IsDeleted);
                dto.Tags.Add(new ParentChildrenTagDto { ParentTagId=tag.Id,ParentTagName=tag.Name,
                    ChildrenTags = _mapper.Map<ICollection<TagDto>>(childTags)});
            }
            return Ok(dto);
        }
    }
}
