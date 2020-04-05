using BlogDAL.Interfaces;
using BlogDAL.Repository;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
