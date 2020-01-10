using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Entities;
using TorneiroMataMata.Domain.Interfaces.Repositories;
using TorneiroMataMata.Infra.Context;

namespace TorneiroMataMata.Infra.Repositories
{
    public class GrupoRepository : RepositoryBase<Grupo>, IGrupoRepository
    {
        private readonly DataContext _grupoRepository;

        public GrupoRepository(DataContext grupoRepository)
            :base(grupoRepository)
        {
            _grupoRepository = grupoRepository;
        }

    }
}
