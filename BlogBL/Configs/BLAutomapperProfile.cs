using AutoMapper;
using BlogBL.Models;
using BlogDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Configs
{
    public class BLAutomapperProfile : Profile
    {
        public BLAutomapperProfile()
        {
            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<Category, CategoryModel>().ReverseMap();

            CreateMap<CommentModel, Comment>().ReverseMap();
            CreateMap<Comment, CommentModel>().ReverseMap();

            CreateMap<PostModel, Post>().ReverseMap();
            CreateMap<Post, PostModel>().ReverseMap();

            CreateMap<TagModel, Tag>().ReverseMap();
            CreateMap<Tag, TagModel>().ReverseMap();

            CreateMap<UserModel, User>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
