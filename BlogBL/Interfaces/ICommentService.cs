using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<CommentModel> GetAll();
        void Create(CommentModel item);
        void Update(CommentModel item);
        void Delete(int id);
        CommentModel GetById(int id);
    }
}
