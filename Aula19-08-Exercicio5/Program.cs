using System;

namespace Aula19_08_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "SenAc";

            Console.WriteLine(nome.Equals("SENAC"));
            Console.WriteLine(nome.ToUpper().Equals("SENAC"));
            Console.WriteLine(nome.Contains("A"));
            Console.WriteLine(nome.ToUpper().Contains("A"));
            Console.WriteLine(nome.IndexOf("A"));
            Console.WriteLine(nome.ToUpper().IndexOf("A"));

            string letra = Console.ReadLine();
            if (nome.ToUpper().Contains(letra))
            {
                Console.WriteLine("Tem a letra na posição" +
                    (nome.ToUpper().IndexOf(letra)+1)
                    );
            }

        }
    }
}
