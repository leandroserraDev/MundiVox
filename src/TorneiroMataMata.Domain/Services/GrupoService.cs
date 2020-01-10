using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Entities;
using TorneiroMataMata.Domain.Interfaces.Repositories;
using TorneiroMataMata.Domain.Interfaces.Services;

namespace TorneiroMataMata.Domain.Services
{
    public class GrupoService : ServiceBase<Grupo>, IGrupoService
    {
        private readonly IGrupoRepository _grupoRepository;

        public GrupoService(IGrupoRepository grupoRepository)
            :base(grupoRepository)
        {
            _grupoRepository = grupoRepository;
        }
    }
}
