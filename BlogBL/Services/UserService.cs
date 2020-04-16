using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
using BlogDAL.Entities;
using BlogDAL.Interfaces;
using BlogDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public class UserService : GenericService<UserBL, User>, IUserService
    {
        private IMapper _mapper;
        public UserService(IGenericRepository<User> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }


        public override UserBL Map(User entity)
        {
            return _mapper.Map<UserBL>(entity);
        }

        public override User Map(UserBL blmodel)
        {
            return _mapper.Map<User>(blmodel);
        }

        public override IEnumerable<UserBL> Map(IList<User> entities)
        {
            return _mapper.Map<IEnumerable<UserBL>>(entities);
        }

        public override IEnumerable<User> Map(IList<UserBL> models)
        {
            return _mapper.Map<IEnumerable<User>>(models);
        }
    }
}
