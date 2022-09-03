using System;

namespace Aula02_09_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Ana", "Maria", "Joao" };
            int []x = { 1, 3, 4, 6, 2, 7 };
            int []y = new int[4];


            foreach(string n in nomes)
            {
                Console.WriteLine(n);
            }

            for(int i=0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            for (int i = 0; i < y.Length; i++)
            {
                y[i] = int.Parse(Console.ReadLine());
            }

            int j = 0;
            while(j < y.Length)
            {
                Console.WriteLine(x[j]);
            }

            j = 0;
            do
            {
                Console.WriteLine(x[j]);
            } while (j < y.Length);




        }
    }
}
