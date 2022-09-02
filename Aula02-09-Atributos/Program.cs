using System;

namespace Aula02_09_Atributos
{
    class Program
    {
        
        //Atributo
        static int x=100;

        static void Main(string[] args)
        {
            int y = 1; 
            Console.WriteLine(y);
            Console.WriteLine(x);
            M1();
            Console.WriteLine(y);
            Console.WriteLine(x);
            M2(y);
            Console.WriteLine(y);
            Console.WriteLine(x);

        }

        static void M2(int y)
        {
            y = 20;
            Console.WriteLine(y);
        }
        static void M1()
        {
            int y = 10;
            Console.WriteLine(y);
        }
    }
}
