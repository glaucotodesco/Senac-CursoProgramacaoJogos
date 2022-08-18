using System;

namespace Aula17_08_Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.Write("Digite um valor inteiroa: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor inteiro: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor inteiro: ");
            n3 = int.Parse(Console.ReadLine());


            if (n1 > n2   &&  n1 > n3)
            {
                Console.WriteLine(n1);
            }
            else{
                if(n2 > n3)
                {
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n3);
                }
            }







        }
    }
}
