using BlogDAL.Interfaces;
using BlogDAL.Repository;
using LightInject;

namespace BlogBL.Configs
{
    public static class BLLightInjectCongiguration
    {
        public static ServiceContainer Congiguration(ServiceContainer container)
        {
            container.Register(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return container;
        }
    }
}
