using AutoMapper;
using BlogBL.Models;
using BlogDAL.Entities;

namespace BlogBL.Configs
{
    public class BLAutomapperProfile : Profile
    {
        public BLAutomapperProfile()
        {
            CreateMap<CategoryBL, Category>().ReverseMap();

            CreateMap<BlogPostBL, Post>().ReverseMap();

            CreateMap<TagBL, Tag>().ReverseMap();

            CreateMap<UserBL, User>().ReverseMap();

        }
    }
}
