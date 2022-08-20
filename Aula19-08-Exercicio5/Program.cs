using System;

/*
   Desenvolver um jogo de perguntas e respostas com 5 perguntas,
   cada pergunta com 4 alternativas.
   Receber a escolha do player para cada pergunta.
   No final mostrar a pontuação do player. 
   Cada pergunta vale 10 pontos.
*/
namespace Aula19_08_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontos = 0;
            string resp;

            Console.WriteLine("Pergunta 1 - Qual é o resultado da expressão:  4 + 1 ");
            Console.WriteLine("A) 4");
            Console.WriteLine("B) 5");
            Console.WriteLine("C) 6");
            Console.WriteLine("D) 7");
            resp = Console.ReadLine();
            if (resp.ToUpper().Equals("B"))
            {
                Console.WriteLine("Você acertou!");
                pontos += 10;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }


            Console.WriteLine("Pergunta 2 - Qual é o resultado da expressão:  3 * 1 ");
            Console.WriteLine("A) 3");
            Console.WriteLine("B) 4");
            Console.WriteLine("C) 0");
            Console.WriteLine("D) 2");

            resp = Console.ReadLine();
            if (resp.ToUpper().Equals("A"))
            {
                Console.WriteLine("Você acertou!");
                pontos += 10;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }


            Console.WriteLine("Pergunta 3 - Qual é o resultado da expressão:   12 / 4 ");
            Console.WriteLine("A) 1");
            Console.WriteLine("B) 2");
            Console.WriteLine("C) 3");
            Console.WriteLine("D) 4");

            resp = Console.ReadLine();
            if (resp.ToUpper().Equals("C"))
            {
                Console.WriteLine("Você acertou!");
                pontos += 10;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }

            Console.WriteLine("Pergunta 4 - Qual é o resultado da expressão:   10 * 0 ");
            Console.WriteLine("A) 1");
            Console.WriteLine("B) 2");
            Console.WriteLine("C) -1");
            Console.WriteLine("D) -0");

            resp = Console.ReadLine();
            if (resp.ToUpper().Equals("D"))
            {
                Console.WriteLine("Você acertou!");
                pontos += 10;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }

            Console.WriteLine("Total de pontos: " + pontos);



        }
    }
}
