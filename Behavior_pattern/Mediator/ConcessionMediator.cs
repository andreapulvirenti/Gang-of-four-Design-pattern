namespace Mediator
{
    public class ConcessionMediator : IMediator
    {

        private NorthConcessionStand northConcessionStand;
        private SouthConcessionStand southConcessionStand;


        public NorthConcessionStand NorthConcession
        {
            set
            {
                northConcessionStand = value;
            }
        }

        public SouthConcessionStand SouthConcessionStand
        {
            set
            {
                southConcessionStand = value;
            }
        }

        public ConcessionMediator()
        {

        }

        public void SendMessage(string message, AConcessionStand concessionStand)
        {
            if (concessionStand == northConcessionStand)
                northConcessionStand.Notify(message);
            if (concessionStand == southConcessionStand)
                southConcessionStand.Notify(message);
        }

    }
}