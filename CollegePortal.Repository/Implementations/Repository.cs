using CollegePortal.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollegePortal.Repository.Implementations
{
    public class Repository<TEnttiy> : IRepository<TEnttiy> where TEnttiy : class
    {
        #region Properties

        protected readonly DbContext dbContext; 

        #endregion

        #region Constructors
        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Methods
        public void Add(TEnttiy entity)
        {
            dbContext.Set<TEnttiy>().Add(entity);
        }

        public void Delete(object id)
        {
            TEnttiy entity = dbContext.Set<TEnttiy>().Find(id);
            if (entity != null)
            {
                dbContext.Set<TEnttiy>().Remove(entity);
            }
        }

        public void Delete(TEnttiy entity)
        {
            dbContext.Set<TEnttiy>().Remove(entity);
        }

        public IEnumerable<TEnttiy> GetAll()
        {
            return dbContext.Set<TEnttiy>().ToList();
        }

        public TEnttiy GetById(object id)
        {
            return dbContext.Set<TEnttiy>().Find(id);
        }

        public void Remove(TEnttiy entity)
        {
            dbContext.Set<TEnttiy>().Remove(entity);
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public void Update(TEnttiy entity)
        {
            dbContext.Set<TEnttiy>().Update(entity);
        } 

        #endregion
    }
}
