using System;


/*
 Receber os nomes de 2 Jogadores
	Para cada jogador sortear:
		O poder: Mínimo 10, Máximo 100
		A magia: Mínimo 10, Máximo 100
		A resistência: Mínimo 10, Máximo 100
	Mostrar na tela, para cada item (poder, magia e resistência),
    quem é o vencedor ou empate (Jogador 1 ou Jogador 2).
*/


namespace Aula18_08_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string player1, player2;
            int poder1, poder2, magia1, magia2, resistencia1, resistencia2;

            //Dados dos Player1
            Console.Write("Digite o nome do player 1");
            player1 = Console.ReadLine();
            poder1 = r.Next(10, 101);
            magia1 = r.Next(10, 101);
            resistencia1 = r.Next(10, 101);

            //Dados dos Player2
            Console.Write("Digite o nome do player 2");
            player2 = Console.ReadLine();
            poder2 = r.Next(10, 101);
            magia2 = r.Next(10, 101);
            resistencia2 = r.Next(10, 101);

            if(poder1 > poder2)
            {
                Console.WriteLine(player1 + " venceu para o poder.");
            }
            else
            {
                if (poder2 > poder1)
                {
                    Console.WriteLine(player2 + " venceu para o poder.");
                }
                else
                {
                    Console.WriteLine("Empatou para o poder");
                }
            }



            if (magia1 > magia2)
            {
                Console.WriteLine(player1 + " venceu para a magia.");
            }
            else
            {
                if (magia2 > magia1)
                {
                    Console.WriteLine(player2 + " venceu para a magia.");
                }
                else
                {
                    Console.WriteLine("Empatou para a magia");
                }
            }

            if (resistencia1 > resistencia2)
            {
                Console.WriteLine(player1 + " venceu para a resistência.");
            }
            else
            {
                if (resistencia2 > resistencia1)
                {
                    Console.WriteLine(player2 + " venceu para a resistência.");
                }
                else
                {
                    Console.WriteLine("Empatou para a resistência");
                }
            }


            
        }
    }
}
