using AutoMapper;
using BlogBL.Configs;
using BlogBL.Interfaces;
using BlogBL.Services;
using LightInject;
using System.Collections.Generic;
using System.Reflection;

namespace BlogApp.App_Start
{
    public static class LightInjectConfig
    {
        public static void Congigurate()
        {
            var container = new ServiceContainer();
            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new WebAutomapperProfile(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLightInjectCongiguration.Congiguration(container);

            container.Register<IPostService, PostService>();
            container.Register<IUserService, UserService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ITagService, TagService>();
            container.Register<ICommentService, CommentService>();

            container.EnableMvc();
        }
    }
}