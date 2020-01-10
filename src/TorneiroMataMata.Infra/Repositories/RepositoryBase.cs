using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Interfaces.Repositories;
using TorneiroMataMata.Infra.Context;

namespace TorneiroMataMata.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DataContext _repositoryBase;

        public RepositoryBase(DataContext repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public virtual void Add(TEntity obj)
        {
            _repositoryBase.Set<TEntity>().Add(obj);
        }

        public virtual void Delete(TEntity obj)
        { 
            _repositoryBase.Set<TEntity>().Remove(obj);
        }

        public virtual void Edit(TEntity obj)
        {
            _repositoryBase.Entry(obj).State = EntityState.Modified;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
          return _repositoryBase.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _repositoryBase.Set<TEntity>().Find(id);
        }

        public virtual void SaveChanges()
        {
            _repositoryBase.SaveChanges();
        }
    }
}
