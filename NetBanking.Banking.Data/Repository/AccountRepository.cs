using NetBanking.Banking.Data.Context;
using NetBanking.Banking.Domain.Interfaces;
using NetBanking.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext dbContext)
        {
            _ctx = dbContext;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
