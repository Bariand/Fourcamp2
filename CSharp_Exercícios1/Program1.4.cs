using System;

namespace CSharp_Exercícios1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e 
            atribua esta operação à variável “prod”. A seguir mostre a variável PROD com 
            mensagem correspondente. 
            Entrada
            O arquivo de entrada contém 2 valores inteiros.
            Exemplos de Entrada Exemplos de Saída
            3
            9
            PROD = 27
            -30
            10
            PROD = -300
            0
            9
            PROD = 0
             */

            int valor1 = 0;
            int valor2 = 0;

            int i = 0;

            Console.WriteLine("Vamos calcular o produto de dois valores.");

            while (i == 0)
            {

                Console.WriteLine("Escreva um valor para a variável valor1:");

                try
                {
                    valor1 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é um Integer. Tente novamente");
                }
            }

            i = 0;

            while (i == 0)
            {

                Console.WriteLine("Escreva um valor para a variável valor2:");

                try
                {
                    valor2 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é um Integer. Tente novamente");
                }
            }

            int prod = valor1 * valor2;

            Console.WriteLine("O resultado da sua soma é: " + prod);
            Console.ReadLine();
        }
    }
}
