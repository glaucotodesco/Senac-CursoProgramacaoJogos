using System;

namespace Aula29_08_Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, soma ;

            num1 = receberDado();
            num2 = receberDado();
            soma = Somar(num1, num2);
            Imprimir(soma);

            num1 = receberDado();
            num2 = receberDado();
            soma = Somar(num1, num2);
            Imprimir(soma);
        }

        static double receberDado()
        {
            Console.WriteLine("Digite um numero: ");
            return double.Parse(Console.ReadLine());
        }

        static void Imprimir(double valor)
        {
            Console.WriteLine("Soma =" + valor);
        }


        static double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

       



    }
}
