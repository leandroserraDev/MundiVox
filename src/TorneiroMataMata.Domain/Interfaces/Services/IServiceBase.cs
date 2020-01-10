using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneiroMataMata.Domain.Interfaces.Services
{
   public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Edit(TEntity obj);
        void Delete(TEntity obj);
        void SaveChanges();
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
