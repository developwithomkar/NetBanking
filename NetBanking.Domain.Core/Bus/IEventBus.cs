using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using NetBanking.Domain.Core.Bus;
using NetBanking.Domain.Core.Command;

namespace NetBanking.Domain.Core.Events
{
    //Basic interface for 
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : NetBanking.Domain.Core.Command.Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe <T,TH>() where T:Event
                                where TH:IEventHandler<T>;
    }
}
