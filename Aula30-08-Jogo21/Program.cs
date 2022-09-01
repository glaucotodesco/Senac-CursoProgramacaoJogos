using System;

namespace Aula30_08_Jogo21
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 1000;
            int cartas, cartaSorteada, totalAposta, continua=1, partida=0;

            while(saldo >= 200 && continua == 1)
            {
                
                partida++;
                Console.Clear();
                Console.WriteLine("\n\n***************** Jogo 21: Partida: " + partida + " *********************");

                //Inicia Partida
                cartaSorteada = SortearCarta();
                Console.WriteLine("Carta Sorteada: " + cartaSorteada);
                cartas = cartaSorteada;

                cartaSorteada = SortearCarta();
                Console.WriteLine("Carta Sorteada: " + cartaSorteada);
                cartas += cartaSorteada;
                saldo -= 50;
                totalAposta = 50;

                //Regras do Jogo
                continua = 1;
                while (cartas < 21 && continua == 1)
                {
                    ImprimirDados(saldo, cartas, totalAposta);
                        
                    Console.WriteLine("Deseja uma nova carta? 1.Sim 2.Não");
                    continua = int.Parse(Console.ReadLine());

                    if (continua == 1)
                    {
                        cartaSorteada = SortearCarta();
                        Console.WriteLine("\nCarta Sorteada: " + cartaSorteada);
                        cartas += cartaSorteada;
                        saldo -= 50;
                        totalAposta += 50;
                    }

                }

                //Verifica se Ganhou!
                if (cartas == 21)
                {

                    Console.WriteLine("Você venceu! Receba o prêmio de R$ " + (totalAposta * 3));
                    saldo += totalAposta * 3;
                    ImprimirDados(saldo, cartas, totalAposta);
                }
                else
                {
                    Console.WriteLine("Você perdeu!");
                    ImprimirDados(saldo, cartas, totalAposta);
                }

                //Tem sadlo para continuar?              
                if(saldo >= 200)
                {
                    Console.WriteLine("Deseja começar uma nova partida? 1.Sim 2.Não");
                    continua = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para continuar!");
                }
          
            }
         }

       
        static void ImprimirDados(double saldo, double cartas, double totalAposta)
        {

            Console.WriteLine("Saldo : " + saldo);
            Console.WriteLine("Soma Cartas : " + cartas);
            Console.WriteLine("Aposta : " + totalAposta);
            Console.WriteLine("Prêmio : " + totalAposta * 3);

        }
        static int SortearCarta()
        {
            Random r = new Random();
            return r.Next(1, 11);
        }

    }
}
