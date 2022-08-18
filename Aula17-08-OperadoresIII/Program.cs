using System;

namespace Aula17_08_OperadoresIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20, z = 30;

            /* 
                &&    E
                ||   OU
            */

            Console.WriteLine((x > y) && (x < z));
            Console.WriteLine((x > y) || (x < z));
        }
    }
}
