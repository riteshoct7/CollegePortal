using System.Collections.Generic;

namespace CollegePortal.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity:class
    {
        #region Methods

        IEnumerable<TEntity> GetAll();

        TEntity GetById(object id);

        void Add(TEntity entity);
        void Update(TEntity entity);

        void Delete(object id);

        void Delete(TEntity entity);

        void Remove(TEntity entity);

        int SaveChanges(); 

        #endregion
    }
}
