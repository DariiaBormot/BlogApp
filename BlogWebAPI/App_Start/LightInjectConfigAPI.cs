using AutoMapper;
using BlogBL.Configs;
using BlogBL.Interfaces;
using BlogBL.Services;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace BlogWebAPI.App_Start
{
    public static class LightInjectConfigAPI
    {
        public static void Congigurate()
        {
            var container = new ServiceContainer();
            container.RegisterApiControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new AutomapperProfileWebAPI(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLightInjectCongiguration.Congiguration(container);

            container.Register<IPostService, PostService>();
            container.Register<IUserService, UserService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ITagService, TagService>();
            container.Register<ICommentService, CommentService>();

            container.EnablePerWebRequestScope();
            container.EnableWebApi(GlobalConfiguration.Configuration);

        }
    }
}