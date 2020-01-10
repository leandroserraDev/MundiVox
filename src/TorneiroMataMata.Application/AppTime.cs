using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Application.Interfaces;
using TorneiroMataMata.Domain.Entities;
using TorneiroMataMata.Domain.Interfaces.Services;

namespace TorneiroMataMata.Application
{
    public class AppTime : AppBase<Time>, IAppTime 
    {
        private readonly ITimeService _appTime;

        public AppTime(ITimeService appTime)
            :base(appTime)
        {
            _appTime = appTime;
        }

        public void AvancarTime(Time time)
        {
            _appTime.AvancarTime(time);
        }
    }
}
