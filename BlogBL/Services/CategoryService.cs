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
    public class CategoryService : GenericService<CategoryBL, Category>, ICategoryService
    {
        private IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override CategoryBL Map(Category entity)
        {
            return _mapper.Map<CategoryBL>(entity);
        }

        public override Category Map(CategoryBL blmodel)
        {
            return _mapper.Map<Category>(blmodel);
        }

        public override IEnumerable<CategoryBL> Map(IList<Category> entities)
        {
            return _mapper.Map<IEnumerable<CategoryBL>>(entities);
        }

        public override IEnumerable<Category> Map(IList<CategoryBL> models)
        {
            return _mapper.Map<IEnumerable<Category>>(models);
        }
    }
}
