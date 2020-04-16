using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
using BlogWebAPI.Filters;
using BlogWebAPI.Filters.CustomExceptions;
using BlogWebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogWebAPI.Controllers
{
    public class BlogPostsController : ApiController
    {
        private IPostService _service;
        private IMapper _mapper;
        public BlogPostsController(IPostService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/BlogPosts
        public IEnumerable<BlogPostData> Get()
        {
            var postsBL = _service.GetAll();
            var postsPL = _mapper.Map<IEnumerable<BlogPostData>>(postsBL);
            return postsPL;
        }

        // GET: api/BlogPosts/5
        [CustomExeptionFilter]
        public BlogPostData Get(int id)
        {
            var postBL = _service.GetById(id);
            var postPL = _mapper.Map<BlogPostData>(postBL);

            if(postPL == null)
            {
                throw new InvalidIdExeption("post with this id is not found", id.ToString());
            }
            return postPL;
        }

        // POST: api/BlogPosts
        [CustomExeptionFilter]
        public void Post([FromBody]BlogPostData model)
        {
            if (string.IsNullOrEmpty(model.Title))
            {
                throw new InvalidTitleExeption("ivalid post title", "title is null or empty");
            }
            else if (string.IsNullOrEmpty(model.Body))
            {
                throw new InvalidBodyException("body can't be empty", "body is null or empty");
            }

            var postBL = _mapper.Map<BlogPostBL>(model);
            _service.Create(postBL);
        }

        // PUT: api/BlogPosts/5
        public void Put([FromBody]BlogPostData model)
        {
            if (string.IsNullOrEmpty(model.Title))
            {
                throw new InvalidTitleExeption("ivalid post title", "title is null or empty");
            }
            else if (string.IsNullOrEmpty(model.Body))
            {
                throw new InvalidBodyException("body can't be empty", "body is null or empty");
            }

            var postBL = _mapper.Map<BlogPostBL>(model);
            _service.Update(postBL);
        }

        // DELETE: api/BlogPosts/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
