using System;
namespace Mediator
{
    public class SouthConcessionStand : AConcessionStand
    {
        private IMediator _mediator;
        public SouthConcessionStand(IMediator mediator) : base(mediator)
        {
 _mediator = mediator;
        }

        public override void Send(string message)
        {
            Console.WriteLine("South Concession Stand sends message: " + message);
            _mediator.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("South Concession Stand gets message: " + message);
        }

    }
}