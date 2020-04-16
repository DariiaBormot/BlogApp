using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
using BlogWebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogWebAPI.Controllers
{
    public class CommentsController : ApiController
    {
        private ICommentService _service;
        private IMapper _mapper;
        public CommentsController(ICommentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/Tag
        public IEnumerable<CommentData> Get()
        {
            var commentsBL = _service.GetAll();
            var commentsPL = _mapper.Map<IEnumerable<CommentData>>(commentsBL);
            return commentsPL;
        }

        // GET: api/Tag/5
        public CommentData Get(int id)
        {
            var commentBL = _service.GetById(id);
            var commentPL = _mapper.Map<CommentData>(commentBL);
            return commentPL;
        }

        // POST: api/Tag
        public void Post([FromBody]CommentData model)
        {
            var commentBL = _mapper.Map<CommentBL>(model);
            _service.Create(commentBL);
        }

        // PUT: api/Tag/5
        public void Put([FromBody]CommentData model)
        {
            var commentBL = _mapper.Map<CommentBL>(model);
            _service.Update(commentBL);
        }

        // DELETE: api/Tag/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
