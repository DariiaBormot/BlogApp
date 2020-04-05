using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserModel> GetAll();
        void Create(UserModel item);
        void Update(UserModel item);
        void Delete(int id);
        UserModel GetById(int id);
    }
}
