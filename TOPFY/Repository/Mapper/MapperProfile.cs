using AutoMapper;
using DomainModels.Dtos.PostDtos;
using DomainModels.Dtos.TagDtos;
using DomainModels.Dtos.UserDtos;
using DomainModels.Models;

namespace Repository.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Tag, TagDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
