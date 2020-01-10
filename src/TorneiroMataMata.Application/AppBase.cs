using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Application.Interfaces;
using TorneiroMataMata.Domain.Interfaces.Services;

namespace TorneiroMataMata.Application
{
    public class AppBase<TEntity> : IAppBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _appService;

        public AppBase(IServiceBase<TEntity> appService)
        {
            _appService = appService;
        }

        public void Add(TEntity obj)
        {
            _appService.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            _appService.Delete(obj);
        }

        public void Edit(TEntity obj)
        {
            _appService.Edit(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _appService.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _appService.GetById(id);
        }

        public void SaveChanges()
        {
            _appService.SaveChanges();
        }
    }
}
