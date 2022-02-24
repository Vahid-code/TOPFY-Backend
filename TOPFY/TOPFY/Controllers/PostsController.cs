using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
                .DeserializeObject<List<TagDto>>(json["list"].ToString());
            List<Post> posts = new();
            foreach (TagDto tag in listOfTags)
            {
                posts.AddRange(
                    (await _unitOfWork.Posts.GetAllPostsWithUsersAndTags
                    (p => !p.IsDeleted && p.MainTagId == tag.Id ||
                    p.SpecificTags.Any(t => t.Id == tag.Id)))
                    );
            }
            int i = 0;
            List<Post> postsToSend = new();
            while (i < count)
            {
                Random r = new();
                int num = r.Next(0, posts.Count);
                Post post = posts[num];
                if (!postsToSend.Any(p => p == post))
                {
                    postsToSend.Add(post);
                    i++;
                }
            }
            return Ok(_mapper.Map<IList<PostDto>>(postsToSend));
        }
    }
}
