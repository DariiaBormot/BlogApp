using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        void Update(TEntity item);
        IEnumerable<TEntity> GetAll();
        void Delete(int id);
        TEntity GetById(int id);
    }
}
