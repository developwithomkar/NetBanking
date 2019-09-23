using Microsoft.Extensions.DependencyInjection;
using NetBanking.Banking.Application.Interfaces;
using NetBanking.Banking.Application.Services;
using NetBanking.Banking.Data.Context;
using NetBanking.Banking.Data.Repository;
using NetBanking.Banking.Domain.Interfaces;
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

            //App layer services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<BankingDbContext>();
        }
    }
}
