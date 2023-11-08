using CoreLayer.DataAccess;
using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Business.Concrete
{
    public class EntityManagerBase<TEntity, TDal> : IEntityManagerBase<TEntity>
        where TEntity : class, IEntity, new()
        where TDal: IEntityRepositoryBase<TEntity>
    {
        private TDal _tdal;
        public EntityManagerBase(TDal tdal)
        {
            _tdal = tdal;
        }

        public void Add(TEntity entity)
        {
            _tdal.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _tdal.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _tdal.GetAll();
        }
        public void Update(TEntity entity)
        {
            _tdal.Update(entity);
        }
    }
}
