﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneiroMataMata.Domain.Entities;

namespace TorneiroMataMata.Application.Interfaces
{
    public interface IAppTime : IAppBase<Time>
    {
        void AvancarTime(Time time);
    }
}
