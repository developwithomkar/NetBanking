using NetBanking.Banking.Application.Models;
using NetBanking.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}
