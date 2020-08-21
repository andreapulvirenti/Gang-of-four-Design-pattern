using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcessionMediator mediator = new ConcessionMediator();
            NorthConcessionStand standNorth = new NorthConcessionStand(mediator);
            SouthConcessionStand standSouth = new SouthConcessionStand(mediator);


            mediator.NorthConcession = standNorth;
            mediator.SouthConcessionStand = standSouth;
            standNorth.Send("Puoi inviarci dei popcorn?");
            standSouth.Send("Si, sta arrivando Luigi");
            standSouth.Send("Ti servono degli snack?");
            standNorth.Send("Mah si portane un paio");

            Console.ReadKey();


        }
    }
}
