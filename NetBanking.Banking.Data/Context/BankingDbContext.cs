using Microsoft.EntityFrameworkCore;
using NetBanking.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Banking.Data.Context
{
    public class BankingDbContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public BankingDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
