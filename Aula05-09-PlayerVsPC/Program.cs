using System;

namespace Aula05_09_PlayerVsPC
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int turnoPlayer;

            turnoPlayer = r.Next(3);
            
            Console.WriteLine("Quem começa?");
            if (turnoPlayer == 1)
            {
                Console.WriteLine("Player");
            }
            else
            {
                Console.WriteLine("PC");
            }


        }
    }
}
