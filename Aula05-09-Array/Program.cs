using System;

namespace Aula05_09_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dados = new int[10];
            int maior;

            for(int i=0; i < dados.Length; i++) 
            {
                Console.Write("Digite um valor: ");
                dados[i] = int.Parse(Console.ReadLine());
            }

            foreach(int v in dados)
            {
                Console.WriteLine(v);
            }

            maior = dados[0];
            foreach (int v in dados)
            {
                if(maior < v)
                {
                    maior = v;
                }
            }
            Console.WriteLine("Maior valor = " + maior);

            Console.Write("Posição =");
            for (int i = 0; i < dados.Length; i++)
            {
                if(dados[i] == maior)
                {
                    Console.Write(" " +( i + 1));
                }
            }




        }
    }
}
