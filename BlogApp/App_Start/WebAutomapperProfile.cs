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
            CreateMap<CategoryModel, CategoryViewModel>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryModel>().ReverseMap();

            CreateMap<CommentModel, CommentViewModel>().ReverseMap();
            CreateMap<CommentViewModel, CommentModel>().ReverseMap();

            CreateMap<PostModel, PostViewModel>().ReverseMap();
            CreateMap<PostViewModel, PostModel>().ReverseMap();

            CreateMap<TagModel, TagViewModel>().ReverseMap();
            CreateMap<TagViewModel, TagModel>().ReverseMap();

            CreateMap<UserModel, UserViewModel>().ReverseMap();
            CreateMap<UserViewModel, UserModel>().ReverseMap();

        }
    }
}