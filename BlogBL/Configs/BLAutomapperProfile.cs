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
            CreateMap<Category, CategoryBL>().ReverseMap();

            CreateMap<CommentBL, Comment>().ReverseMap();
            CreateMap<Comment, CommentBL>().ReverseMap();

            CreateMap<BlogPostBL, Post>().ReverseMap();
            CreateMap<Post, BlogPostBL>().ReverseMap();

            CreateMap<TagBL, Tag>().ReverseMap();
            CreateMap<Tag, TagBL>().ReverseMap();

            CreateMap<UserBL, User>().ReverseMap();
            CreateMap<User, UserBL>().ReverseMap();
        }
    }
}
