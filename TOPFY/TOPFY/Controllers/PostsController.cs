using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DomainModels.Dtos;
using DomainModels.Dtos.PostDtos;
using DomainModels.Dtos.TagDtos;
using DomainModels.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Repository.Services.Abstarction;

namespace TOPFY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PostsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> GetPosts([FromBody] JObject json, [FromQuery] int count)
        {
            List<TagDto> listOfTags = JsonConvert
                .DeserializeObject<List<TagDto>>(json["tags"].ToString());
            int currentPage = JsonConvert
                .DeserializeObject<int>(json["currentPage"].ToString());
            List<Post> posts = new();
            foreach (TagDto tag in listOfTags)
            {
                List<Post> temp = (await _unitOfWork.Posts.GetAllPostsWithUsersAndTags
                    (p => !p.IsDeleted && p.MainTagId == tag.Id ||
                    p.SpecificTags.Any(t => t.Id == tag.Id))).ToList();
                if (temp.Count != 0)
                {
                    posts.AddRange(temp);
                }
            }
            ExplorerPageDto dto = new(currentPage, count,_mapper.Map<List<PostDto>>(posts),listOfTags);
            return Ok(dto);
        }
    }
}
