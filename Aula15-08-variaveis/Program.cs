using System;

namespace Aula15_08_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            double y = 10.5;
            double z = 10;
            string name ="Senac";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(name);

            Console.WriteLine(x + y + z + name);
            Console.WriteLine(name + x + y + z);
            Console.WriteLine(1 + 2 + 3 + name + 1 + 2 + 3);
            Console.WriteLine(1 + 2 + 3 + name + (1 + 2 + 3));

        }
    }
}
