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
    public class TimeRepository : RepositoryBase<Time>, ITimeRepository
    {
        private readonly DataContext _timeRepository;

        public TimeRepository(DataContext timeRepository)
            :base(timeRepository)
        {
            _timeRepository = timeRepository;
        }

        public  void AvancarTime(Time time)
        {
            var timeBanco = _timeRepository.Times.Where(x => x.TimeId == time.TimeId).FirstOrDefault();

            timeBanco.TrocarNome(timeBanco.Nome);
            timeBanco.AlterarGrupo(time.GrupoId);
        }

        public override void Edit(Time time)
        {
            var timeBanco = _timeRepository.Times.Where(x => x.TimeId == time.TimeId).FirstOrDefault();

            timeBanco.TrocarNome(timeBanco.Nome);
            timeBanco.AddGol(time.Gol);
        }


    }
}
