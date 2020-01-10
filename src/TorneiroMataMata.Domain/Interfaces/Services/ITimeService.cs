using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Entities;

namespace TorneiroMataMata.Domain.Interfaces.Services
{
    public interface ITimeService : IServiceBase<Time>
    {
        void AvancarTime(Time time);
    }
}
