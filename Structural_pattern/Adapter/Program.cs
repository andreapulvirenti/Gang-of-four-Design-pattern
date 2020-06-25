using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var goku = new Sayan();
            var junior = new Namkie();
            var C17 = new AndroidAdapter( new Android());

            Console.WriteLine($"Goku Attack:  { goku.Attack()}" );
            Console.WriteLine($"Junior Attack:  { junior .Attack()}" );
            Console.WriteLine($"C17 Attack:  { C17.Attack()}" );

        }
    }
}
