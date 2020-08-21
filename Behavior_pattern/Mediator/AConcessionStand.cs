namespace Mediator
{
    public abstract class AConcessionStand //chiosco delle bibite al cinema
    {
        private IMediator _mediator;
        public AConcessionStand(IMediator mediator){
            this._mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Notify(string message);

    }
}