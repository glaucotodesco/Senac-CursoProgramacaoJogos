using System;

namespace Aula17_08_Comando_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;

            Console.Write("Digite um valor: ");
            val = int.Parse(Console.ReadLine());

            if(val > 10)
            {
                Console.WriteLine("A");
            }

            if (val > 10 && val < 20)
            {
                Console.WriteLine("B");
            }

            if (val > 10 || val < 20)
            {
                Console.WriteLine("C");
            }

            if (val < 10 || val > 20)
            {
                Console.WriteLine("D");
            }


            if (val >= 10)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("F");
            }



            Console.WriteLine("FIM!!!!");



        }
    }
}
