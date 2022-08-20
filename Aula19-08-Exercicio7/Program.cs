using System;


/*
 
 Faça um programa no qual o usuário tem 5 tentativas para descobrir uma palavra com 5 letras.
	Regra 1: O usuário deve digitar um caracter em cada tentativa.
	Regra 2: A palavra não tem caracteres repitidos.
	Regra 3: Em cada tentativa a sua aplicação deverá mostrar se uma letra tem ou não na palavra. 
	         Se tiver mostrar a posição da letra na palavra.
 
*/

namespace Aula19_08_Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "SENAC", letra, resp;

            Console.WriteLine("Tente acertar uma palavra com 5 letras.");
            Console.WriteLine("Não existem letras repitidas.");


            Console.WriteLine("\nDigite uma letra: ");
            letra = Console.ReadLine().ToUpper();
            if (palavra.Contains(letra))
            {
                Console.WriteLine("Tem a letra na posição:  " + (palavra.IndexOf(letra) + 1));
            }
            else
            {
                Console.WriteLine("Não tem a letra");
            }

            Console.WriteLine("\nDigite uma letra: ");
            letra = Console.ReadLine().ToUpper();
            if (palavra.Contains(letra))
            {
                Console.WriteLine("Tem a letra na posição:  " + (palavra.IndexOf(letra) + 1));
            }
            else
            {
                Console.WriteLine("Não tem a letra");
            }

            Console.WriteLine("\nDigite uma letra: ");
            letra = Console.ReadLine().ToUpper();
            if (palavra.Contains(letra))
            {
                Console.WriteLine("Tem a letra na posição:  " + (palavra.IndexOf(letra) + 1));
            }
            else
            {
                Console.WriteLine("Não tem a letra");
            }

            Console.WriteLine("\nDigite uma letra: ");
            letra = Console.ReadLine().ToUpper();
            if (palavra.Contains(letra))
            {
                Console.WriteLine("Tem a letra na posição:  " + (palavra.IndexOf(letra) + 1));
            }
            else
            {
                Console.WriteLine("Não tem a letra");
            }

            Console.WriteLine("\nDigite uma letra: ");
            letra = Console.ReadLine().ToUpper();
            if (palavra.Contains(letra))
            {
                Console.WriteLine("Tem a letra na posição:  " + (palavra.IndexOf(letra) + 1));
            }
            else
            {
                Console.WriteLine("Não tem a letra");
            }

            Console.WriteLine("\n\nVocê sabe qual é a palavra? Digite a palavra: ");
            resp = Console.ReadLine();
            if (resp.ToUpper().Equals(palavra))
            {
                Console.WriteLine("Você acertou!");
            }
            else
            {
                Console.WriteLine("Você errou! A palavra era: " + palavra);
            }






        }
    }
}
