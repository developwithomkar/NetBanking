﻿using NetBanking.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
