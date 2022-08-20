using System;

/*
    Faça um programa no qual o usuário deverá descobrir o nome de um objeto com 5 dicas. 
	Ao mostrar cada dica, o usuário deverá digitar o nome do objeto. 
	Se ele acertar o nome do objeto, finalizar a aplicação. 
	Se ao final das 5 dicas ele não acertar o nome do objeto,
	mostrar o nome do objeto e finalizar a aplicação.
 */

namespace Aula19_08_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string objeto = "BOLA", resp;

            Console.WriteLine("Dica 1 - Pode ser usado com várias partes do corpo como pés e mãos");
            Console.WriteLine("Qual é o objeto? ");
            resp = Console.ReadLine();
            if (resp.ToUpper().Equals(objeto))
            {
                Console.WriteLine("Acertou!");
            }
            else
            {
                Console.WriteLine("Dica 2 - É usado em vários esportes");
                Console.WriteLine("Qual é o objeto? ");
                resp = Console.ReadLine();
                if (resp.ToUpper().Equals(objeto))
                {
                    Console.WriteLine("Acertou!");
                }
                else
                {
                    Console.WriteLine("Dica 3 - Tem de vários tamanhos e tipos de materiais");
                    Console.WriteLine("Qual é o objeto? ");
                    resp = Console.ReadLine();
                    if (resp.ToUpper().Equals(objeto))
                    {
                        Console.WriteLine("Acertou!");
                    }
                    else
                    {
                        Console.WriteLine("Dica 4 - Usado em um esporte muito popular no mundo");
                        Console.WriteLine("Qual é o objeto? ");
                        resp = Console.ReadLine();
                        if (resp.ToUpper().Equals(objeto))
                        {
                            Console.WriteLine("Acertou!");
                        }
                        else
                        {
                            Console.WriteLine("Dica 5 - Começa com a letra B");
                            Console.WriteLine("Qual é o objeto? ");
                            resp = Console.ReadLine();
                            if (resp.ToUpper().Equals(objeto))
                            {
                                Console.WriteLine("Acertou!");
                            }
                            else
                            {
                                Console.WriteLine("Você errou! O objeto era:  " + objeto);
                            }
                        }
                    }
                }
            }

        }
    }
}
