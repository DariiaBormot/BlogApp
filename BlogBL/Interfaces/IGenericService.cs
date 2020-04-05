using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interfaces
{
    public interface IGenereicService<Model>
    where Model : class
    {
        void Create(Model item);
        void Update(Model item);
        IEnumerable<Model> GetAll();
        void Delete(int id);
        Model GetById(int id);
    }
}
