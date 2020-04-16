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

            CreateMap<CommentBL, CommentViewModel>().ReverseMap();

            CreateMap<BlogPostBL, PostViewModel>().ReverseMap();

            CreateMap<TagBL, TagViewModel>().ReverseMap();

            CreateMap<UserBL, UserViewModel>().ReverseMap();

        }
    }
}