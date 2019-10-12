using NetBanking.Banking.Application.Interfaces;
using NetBanking.Banking.Application.Models;
using NetBanking.Banking.Domain.Commands;
using NetBanking.Banking.Domain.Interfaces;
using NetBanking.Banking.Domain.Models;
using NetBanking.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IEventBus bus;

        public AccountService(IAccountRepository aRepo, IEventBus ebus)
        {
            accountRepository = aRepo;
            bus = ebus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer at)
        {
            var initTransferCmd = new InitiateTransferCommand
                                    (at.AccountFrom, 
                                    at.AccountTo, 
                                    at.Amount);

            bus.SendCommand(initTransferCmd);
               
        }
    }
}
