using System.Collections.Generic;

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
