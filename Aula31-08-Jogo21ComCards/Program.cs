using System;

namespace Aula31_08_Jogo21ComCards
{
  
    class Program
    {
        static int[] cartasUsadas = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static string[] cartasDesenho = {
 @"
.------.
|1.--. |
| :/\: |
| (__) |
| '--'1|
`------'",
 @"
.------.
|2.--. |
| (\/) |
| :\/: |
| '--'2|
`------'
",
 @"
.------.
|3.--. |
| :(): |
| ()() |
| '--'3|
`------'
",
 @"
.------.
|4.--. |
| :/\: |
| :\/: |
| '--'4|
`------'
",
 @"
.------.
|5.--. |
| :/\: |
| (__) |
| '--'5|
`------'",
 @"
.------.
|6.--. |
| (\/) |
| :\/: |
| '--'6|
`------'
",
 @"
.------.
|7.--. |
| :(): |
| ()() |
| '--'7|
`------'
",
 @"
.------.
|8.--. |
| :/\: |
| :\/: |
| '--'8|
`------'
",
 @"
.------.
|9.--. |
| :/\: |
| (__) |
| '--'9|
`------'
",
 @"
.------.
|10.-. |
| :/\: |
| (__) |
| '-'10|
`------'
"
        };

       
            static void Main(string[] args)
            {
                double saldo = 1000;
                int cartas, cartaSorteada, totalAposta, continua = 1, partida = 0;

                while (saldo >= 200 && continua == 1)
                {

                    partida++;
                    Array.Clear(cartasUsadas, 0, 10);
                    Console.Clear();

                    Console.WriteLine("\n\n***************** Jogo 21 - Versão Cards: Partida: " + partida + " *********************");

                    //Inicia Partida
                    cartaSorteada = SortearCarta();
                    Console.WriteLine("Carta Sorteada: " + cartasDesenho[cartaSorteada-1]);
                    cartas = cartaSorteada;

                    cartaSorteada = SortearCarta();
                    Console.WriteLine("Carta Sorteada: " + cartasDesenho[cartaSorteada - 1]);
                    cartas += cartaSorteada;
                    saldo -= 50;
                    totalAposta = 50;

                    //Regras do Jogo
                    continua = 1;
                    while (cartas < 21 && continua == 1)
                    {
                        ImprimirDados(saldo, cartas, totalAposta);

                        Console.Write("\nDeseja uma nova carta? 1.Sim 2.Não ");
                        continua = int.Parse(Console.ReadLine());

                        if (continua == 1)
                        {
                            cartaSorteada = SortearCarta();
                            Console.WriteLine("\nCarta Sorteada: " + cartasDesenho[cartaSorteada - 1]);
                            cartas += cartaSorteada;
                            saldo -= 50;
                            totalAposta += 50;
                        }
                    }

                    //Verifica se Ganhou!
                    if (cartas == 21)
                    {

                        Console.WriteLine("Você venceu! Recebeu o prêmio de R$ " + (totalAposta * 3));
                        saldo += totalAposta * 3;
                        ImprimirDados(saldo, cartas, totalAposta);
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu!");
                        ImprimirDados(saldo, cartas, totalAposta);
                    }

                    //Tem sadlo para continuar?              
                    if (saldo >= 200)
                    {
                        Console.WriteLine("Deseja começar uma nova partida? 1.Sim 2.Não");
                        continua = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para continuar, fim de jogo!");
                    }

                }




            }


            static void ImprimirDados(double saldo, double cartas, double totalAposta)
            {

                Console.WriteLine("Saldo.......: R$ " + saldo.ToString("N2"));
                Console.WriteLine("Soma Cartas.: "    + cartas);
                Console.WriteLine("Aposta..... : R$ " + totalAposta.ToString("N2"));
                Console.WriteLine("Prêmio..... : R$ " + (totalAposta * 3).ToString("N2"));

            }
            static int SortearCarta()
            {
              
                Random r = new Random();
                int val;

                do
                {
                    val = r.Next(1, 11); 
                } while (cartasUsadas[val-1] != 0);

                cartasUsadas[val - 1] = val;

                return val;
                
            }

        }
    }
