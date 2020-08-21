using System;
namespace Mediator
{
    public class NorthConcessionStand : AConcessionStand
    {
        private IMediator _mediator;
        public NorthConcessionStand(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        public override void Send(string message)
        {
            Console.WriteLine("North Concession Stand sends message: " + message);
            _mediator.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("North Concession Stand gets message: " + message);
        }
    }
}