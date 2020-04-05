using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryModel> GetAll();
        void Create(CategoryModel item);
        void Update(CategoryModel item);
        void Delete(int id);
        CategoryModel GetById(int id);
    }
}
