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
    public class PostService : GenericService<PostModel, Post>, IPostService
    {
        private IMapper _mapper;
        public PostService(IGenericRepository<Post> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override PostModel Map(Post entity)
        {
            return _mapper.Map<PostModel>(entity);
        }

        public override Post Map(PostModel blmodel)
        {
            return _mapper.Map<Post>(blmodel);
        }

        public override IEnumerable<PostModel> Map(IList<Post> entities)
        {
            return _mapper.Map<IEnumerable<PostModel>>(entities);
        }

        public override IEnumerable<Post> Map(IList<PostModel> models)
        {
            return _mapper.Map<IEnumerable<Post>>(models);
        }
    }
}
