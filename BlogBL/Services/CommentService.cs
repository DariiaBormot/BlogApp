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
    public class CommentService : GenericService<CommentModel, Comment>, ICommentService
    {
        private IMapper _mapper;
        public CommentService(IGenericRepository<Comment> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override CommentModel Map(Comment entity)
        {
            return _mapper.Map<CommentModel>(entity);
        }

        public override Comment Map(CommentModel blmodel)
        {
            return _mapper.Map<Comment>(blmodel);
        }

        public override IEnumerable<CommentModel> Map(IList<Comment> entities)
        {
            return _mapper.Map<IEnumerable<CommentModel>>(entities);
        }

        public override IEnumerable<Comment> Map(IList<CommentModel> models)
        {
            return _mapper.Map<IEnumerable<Comment>>(models);
        }
    }
}
