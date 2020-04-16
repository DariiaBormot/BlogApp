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
    public class CategoriesController : ApiController
    {
        private ICategoryService _service;
        private IMapper _mapper;
        public CategoriesController(ICategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/Tag
        public IEnumerable<CategoryData> Get()
        {
            var categoriesBL = _service.GetAll();
            var categoriesPL = _mapper.Map<IEnumerable<CategoryData>>(categoriesBL);
            return categoriesPL;
        }

        // GET: api/Tag/5
        public CategoryData Get(int id)
        {
            var categoryBL = _service.GetById(id);
            var categoryPL = _mapper.Map<CategoryData>(categoryBL);
            return categoryPL;
        }

        // POST: api/Tag
        public void Post([FromBody]CategoryData model)
        {
            var categoryBL = _mapper.Map<CategoryBL>(model);
            _service.Create(categoryBL);
        }

        // PUT: api/Tag/5
        public void Put([FromBody]CategoryData model)
        {
            var categoryBL = _mapper.Map<CategoryBL>(model);
            _service.Update(categoryBL);
        }

        // DELETE: api/Tag/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
