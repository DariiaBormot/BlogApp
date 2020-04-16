using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
using BlogDAL.Entities;
using BlogDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public class CommentService : GenericService<CommentBL, Comment>, ICommentService
    {
        private IMapper _mapper;
        public CommentService(IGenericRepository<Comment> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override CommentBL Map(Comment entity)
        {
            return _mapper.Map<CommentBL>(entity);
        }

        public override Comment Map(CommentBL blmodel)
        {
            return _mapper.Map<Comment>(blmodel);
        }

        public override IEnumerable<CommentBL> Map(IList<Comment> entities)
        {
            return _mapper.Map<IEnumerable<CommentBL>>(entities);
        }

        public override IEnumerable<Comment> Map(IList<CommentBL> models)
        {
            return _mapper.Map<IEnumerable<Comment>>(models);
        }
    }
}
