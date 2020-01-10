using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Entities;
using TorneiroMataMata.Application.Interfaces;
using TorneiroMataMata.Domain.Interfaces.Services;

namespace TorneiroMataMata.Application
{
   public class AppGrupo : AppBase<Grupo>, IAppGrupo
    {
        private readonly IGrupoService _grupoService;
        public AppGrupo(IGrupoService grupoService)
            :base(grupoService)
        {
            _grupoService = grupoService;
        }
    }
}
