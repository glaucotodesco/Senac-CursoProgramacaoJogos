using System;

/*
 * Implementar o jogo JokenPô: 1.Pedra, 2.Tesoura e 3.Papel.
 * Player vc Computador.
 * Mostrar a jogada do computador.
 * Mostrar quem ganhou ou empate.
 * O player digita: 1 2 ou 3.
 * Se digitar um valor diferente, mostrar uma mensagem de erro.
 *  
 */ 
namespace Aula22_08_Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int jogadaPlayer, jogadaComputador, result;
            Random r = new Random();

            Console.WriteLine("\n******************* Jokenpô Game ***********************");
            Console.Write("\nDigite 1 (Pedra), 2 (Tesoura) ou 3 (Papel): ");

            jogadaPlayer = int.Parse(Console.ReadLine());
            jogadaComputador = r.Next(1, 4);


            /*
             *   Player     Computador  
             *      1    -       2      = -1   (player win)
             *      2    -       1      =  1
             *   
             *      2    -       3      = -1   (player win)
             *      3    -       2      =  1
             *   
             *      3    -       1      =  2   (player win)
             *      1    -       3      = -2
             */

            result = jogadaPlayer - jogadaComputador;

            if (jogadaPlayer < 1 || jogadaPlayer > 3)
            {
                Console.WriteLine("Erro, você deve escolher um valor de 1 à 3!");
            }
            else
            {
                //Mostra jogada do player
                if (jogadaPlayer == 1)
                {
                    Console.WriteLine("\nVocê jogou: PEDRA");
                }
                else
                {
                    if (jogadaPlayer == 2)
                    {
                        Console.WriteLine("\nVocê jogou: TESOURA");
                    }
                    else
                    {
                        Console.WriteLine("\nVocê jogou: PAPEL");
                    }
                }

                //Mostra jogada do computador
                if (jogadaComputador == 1)
                {
                    Console.WriteLine("\nComputador jogou: PEDRA");
                }
                else
                {
                    if (jogadaComputador == 2)
                    {
                        Console.WriteLine("\nComputador jogou: TESOURA");
                    }
                    else
                    {
                        Console.WriteLine("\nComputador jogou: PAPEL");
                    }
                }


                //Verifica empate ou vitoria
                if (result == 0)
                {
                    Console.WriteLine("\n****************** Empate !!!!!!!! *********************");
                }
                else
                {
                    if (result == -1 || result == 2)
                    {
                        Console.WriteLine("\n****************** Você venceu!!!! *********************");
                    }
                    else
                    {
                        Console.WriteLine("\n****************** Você perdeu!!!! *********************");
                    }
                }

            }

        }
    }
}
