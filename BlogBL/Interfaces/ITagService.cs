using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interfaces
{
    public interface ITagService
    {
        IEnumerable<TagModel> GetAll();
        void Create(TagModel item);
        void Update(TagModel item);
        void Delete(int id);
        TagModel GetById(int id);
    }
}
