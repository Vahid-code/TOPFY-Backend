using AutoMapper;
using DomainModels.Dtos.TagDtos;
using DomainModels.Models;

namespace Repository.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Tag, TagDto>().ReverseMap();
        }
    }
}
