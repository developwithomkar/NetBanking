﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Banking.Domain.Commands
{
    public class InitiateTransferCommand:TransferCommand
    {

        public InitiateTransferCommand(int from,int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
