using NetBanking.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetBanking.Domain.Core.Command
{
    //Basic class to implements different kinds of commands
    public abstract class Command:Message
    {
        
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
