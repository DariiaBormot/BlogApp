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
    public class TagsController : ApiController
    {
        private ITagService _service;
        private IMapper _mapper;
        public TagsController(ITagService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/Tag
        public IEnumerable<TagData> Get()
        {
            var tagsBL = _service.GetAll();
            var tagsPL = _mapper.Map<IEnumerable<TagData>>(tagsBL);
            return tagsPL;
        }

        // GET: api/Tag/5
        public TagData Get(int id)
        {
            var tagBL = _service.GetById(id);
            var tagPL = _mapper.Map<TagData>(tagBL);
            return tagPL;
        }

        // POST: api/Tag
        public void Post([FromBody]TagData model)
        {
            var postBL = _mapper.Map<TagBL>(model);
            _service.Create(postBL);
        }

        // PUT: api/Tag/5
        public void Put([FromBody]TagData model)
        {
            var postBL = _mapper.Map<TagBL>(model);
            _service.Update(postBL);
        }

        // DELETE: api/Tag/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
