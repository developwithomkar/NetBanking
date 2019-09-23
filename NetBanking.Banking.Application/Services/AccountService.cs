using NetBanking.Banking.Application.Interfaces;
using NetBanking.Banking.Domain.Interfaces;
using NetBanking.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository aRepo)
        {
            accountRepository = aRepo;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }
    }
}
