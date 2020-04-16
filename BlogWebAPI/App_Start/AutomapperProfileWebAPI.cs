using AutoMapper;
using BlogBL.Models;
using BlogWebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.App_Start
{
    public class AutomapperProfileWebAPI : Profile
    {
        public AutomapperProfileWebAPI()
        {
            CreateMap<CategoryBL, CategoryData>().ReverseMap();

            CreateMap<BlogPostBL, BlogPostData>().ReverseMap();

            CreateMap<TagBL, TagData>().ReverseMap();

            CreateMap<UserBL, UserData>().ReverseMap();
        }

    }
}