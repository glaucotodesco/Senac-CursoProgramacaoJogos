using System;

/*
 Exercício 2:
  Sortear um valor inteiro de 1 à 10.
  O usuário terá 3 chances de acertar o valor sorteado.
  Mostrar na tela se o usuário acertou ou errou. Se errou mostrar o valor
*/

namespace Aula18_08_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sorteio, numero;

            Random r = new Random();
            sorteio = r.Next(1, 11);

            //Console.WriteLine("Numero sorteado = " + sorteio);

            Console.WriteLine("Digite a sua chance 1: ");
            numero = int.Parse(Console.ReadLine());

            if(numero == sorteio)
            {
                Console.WriteLine("Parabéns! Você acertou de primeira!");
            }
            else
            {
                Console.WriteLine("Digite a sua chance 2: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == sorteio)
                {
                    Console.WriteLine("Parabéns! Você acertou!");
                }
                else
                {
                    Console.WriteLine("Digite a sua chance 3: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero == sorteio)
                    {
                        Console.WriteLine("Parabéns! Você acertou!");
                    }
                    else
                    {
                        Console.WriteLine("Você não acertou! Número sorteado = " + sorteio);
                    }
                }

            }



        }
    }
}
