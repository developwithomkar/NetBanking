using MediatR;
using NetBanking.Banking.Domain.Commands;
using NetBanking.Banking.Domain.Events;
using NetBanking.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetBanking.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<InitiateTransferCommand, bool>
    {

        private readonly IEventBus bus;

        public TransferCommandHandler(IEventBus b)
        {
            bus = b;
        }
        public Task<bool> Handle(InitiateTransferCommand request, CancellationToken cancellationToken)
        {
            bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult<bool>(true);
        }
    }
}
