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
    public class PostService : GenericService<BlogPostBL, Post>, IPostService
    {
        private IMapper _mapper;
        public PostService(IGenericRepository<Post> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override BlogPostBL Map(Post entity)
        {
            return _mapper.Map<BlogPostBL>(entity);
        }

        public override Post Map(BlogPostBL blmodel)
        {
            return _mapper.Map<Post>(blmodel);
        }

        public override IEnumerable<BlogPostBL> Map(IList<Post> entities)
        {
            return _mapper.Map<IEnumerable<BlogPostBL>>(entities);
        }

        public override IEnumerable<Post> Map(IList<BlogPostBL> models)
        {
            return _mapper.Map<IEnumerable<Post>>(models);
        }
    }
}
