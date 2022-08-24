using System;

/*
 * Jogo dos dados
 * Você vs Computador
 * Lançar 2 dados por turno.
 * Verificar quem é o vencedor ou se deu empate.
 * Ao final de 10 turnos mostrar:
 * 
 * Total de vitórias do Jogador
 * Total de vitórias do Computador
 * Total de empates
 * 
 * Mostrar quem venceu ou se deu empate após 10 turnos.
 * 
 * 
 */



namespace Aula22_08_Exercicio9_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado1, dado2, somaPlayer, somaComputador, totalPlayer=0, totalComputador=0, turno = 1;
            Random r = new Random();

            while (turno <= 10)
            {
                Console.WriteLine("\n************** Turno: " + turno + " **************");

                dado1 = r.Next(1, 7);
                dado2 = r.Next(1, 7);
                somaPlayer = dado1 + dado2;
                Console.WriteLine("Jogada player: " + dado1 + " e " + dado2 + ". Total = " + somaPlayer);

                dado1 = r.Next(1, 7);
                dado2 = r.Next(1, 7);
                somaComputador = dado1 + dado2;
                Console.WriteLine("Jogada computador: " + dado1 + " e " + dado2 + ". Total = " + somaComputador);

                if(somaPlayer > somaComputador)
                {
                    Console.WriteLine("Você venceu esse turno!");
                    totalPlayer++;
                }
                else
                {
                    if (somaComputador > somaPlayer)
                    {
                        Console.WriteLine("Você perdeu esse turno!");
                        totalComputador++;
                    }
                    else
                    {
                        Console.WriteLine("Esse turno deu empate!");
                    }
                }
                turno++;
            }

            
            if (totalPlayer > totalComputador)
            {
                Console.WriteLine(@" 

██    ██  ██████   ██████ ███████     ██    ██ ███████ ███    ██  ██████ ███████ ██    ██ 
██    ██ ██    ██ ██      ██          ██    ██ ██      ████   ██ ██      ██      ██    ██ 
██    ██ ██    ██ ██      █████       ██    ██ █████   ██ ██  ██ ██      █████   ██    ██ 
 ██  ██  ██    ██ ██      ██           ██  ██  ██      ██  ██ ██ ██      ██      ██    ██ 
  ████    ██████   ██████ ███████       ████   ███████ ██   ████  ██████ ███████  ██████  
                                                                                          
                                                                                          
                    ");
            }
            else
            {
                if (totalComputador > totalPlayer)
                {
                    Console.WriteLine(@"

██    ██  ██████   ██████ ███████     ██████  ███████ ██████  ██████  ███████ ██    ██ 
██    ██ ██    ██ ██      ██          ██   ██ ██      ██   ██ ██   ██ ██      ██    ██ 
██    ██ ██    ██ ██      █████       ██████  █████   ██████  ██   ██ █████   ██    ██ 
 ██  ██  ██    ██ ██      ██          ██      ██      ██   ██ ██   ██ ██      ██    ██ 
  ████    ██████   ██████ ███████     ██      ███████ ██   ██ ██████  ███████  ██████  
                                                                                       
                                                                                       

 ");
                }
                else
                {
                    Console.WriteLine(@"

███████ ███    ███ ██████   █████  ████████ ███████ 
██      ████  ████ ██   ██ ██   ██    ██    ██      
█████   ██ ████ ██ ██████  ███████    ██    █████   
██      ██  ██  ██ ██      ██   ██    ██    ██      
███████ ██      ██ ██      ██   ██    ██    ███████ 
                                                    
                                                    


");
                }
                
            }
           

        }
    }
}
