using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Interfaces.Repositories;
using TorneiroMataMata.Domain.Interfaces.Services;

namespace TorneiroMataMata.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _serviceBase;

        public ServiceBase(IRepositoryBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            _serviceBase.Delete(obj);
        }

        public void Edit(TEntity obj)
        {
            _serviceBase.Edit(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void SaveChanges()
        {
            _serviceBase.SaveChanges();
        }
    }
}
