using Microsoft.Extensions.DependencyInjection;
using NetBanking.Domain.Core.Events;
using NetBanking.Infra.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain.Bus == RabbitMQ
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
