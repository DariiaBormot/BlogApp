using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostModel> GetAll();
        void Create(PostModel item);
        void Update(PostModel item);
        void Delete(int id);
        PostModel GetById(int id);

    }
}
