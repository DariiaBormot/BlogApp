using BlogBL.Interfaces;
using BlogDAL.Interfaces;
using BlogDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public abstract class GenericService<BLModel, DModel> : IGenereicService<BLModel>
       where BLModel : class
       where DModel : class
    {
        private readonly IGenericRepository<DModel> _repositry;
        public GenericService(IGenericRepository<DModel> repository)
        {
            _repositry = repository;
        }

        public void Create(BLModel item)
        {
            var model = Map(item);
            _repositry.Create(model);
        }

        public void Delete(int id)
        {
            _repositry.Delete(id);
        }

        public IEnumerable<BLModel> GetAll()
        {
            var listEntity = _repositry.GetAll().ToList();
            return Map(listEntity);
        }

        public BLModel GetById(int id)
        {
            var model = _repositry.GetById(id);
            return Map(model);
        }
        public void Update(BLModel item)
        {
            var model = Map(item);
            _repositry.Update(model);
        }

        public abstract BLModel Map(DModel entity);
        public abstract DModel Map(BLModel blmodel);

        public abstract IEnumerable<BLModel> Map(IList<DModel> entities);
        public abstract IEnumerable<DModel> Map(IList<BLModel> models);


    }
}
