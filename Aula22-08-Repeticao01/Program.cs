using System;

namespace Aula22_08_Repeticao01
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i = 0, j;
        
            while(i < 15)
            {
                Console.WriteLine("Hello World! ");
                i++;
            }

            Console.WriteLine("Digite o valor de j: ");
            j = int.Parse(Console.ReadLine());
            i = 0;
            while (i < j)
            {
                Console.WriteLine("Só tem louco!!!! ");
                i++;
            }


        }
    }
}
