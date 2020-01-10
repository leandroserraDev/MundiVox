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
   public class TimeService : ServiceBase<Time>, ITimeService
    {
        private readonly ITimeRepository _timeService;

        public TimeService(ITimeRepository timeService)
            :base(timeService)
        {
            _timeService = timeService;
        }

        public void AvancarTime(Time time)
        {
            _timeService.AvancarTime(time);
        }
    }
}
