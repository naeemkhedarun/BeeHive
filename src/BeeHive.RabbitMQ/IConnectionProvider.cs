﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;

namespace BeeHive.RabbitMQ
{
    public interface IConnectionProvider
    {
        IConnection GetConnection();
    }

}
