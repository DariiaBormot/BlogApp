using AutoMapper;
using BlogApp.Models;
using BlogBL.Models;
using BlogDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<CategoryBL, CategoryViewModel>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryBL>().ReverseMap();

            CreateMap<CommentBL, CommentViewModel>().ReverseMap();
            CreateMap<CommentViewModel, CommentBL>().ReverseMap();

            CreateMap<BlogPostBL, PostViewModel>().ReverseMap();
            CreateMap<PostViewModel, BlogPostBL>().ReverseMap();

            CreateMap<TagBL, TagViewModel>().ReverseMap();
            CreateMap<TagViewModel, TagBL>().ReverseMap();

            CreateMap<UserBL, UserViewModel>().ReverseMap();
            CreateMap<UserViewModel, UserBL>().ReverseMap();

        }
    }
}