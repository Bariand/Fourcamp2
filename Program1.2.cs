using System;

namespace CSharp_Exercícios1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             2) Leia dois valores inteiros, no caso para variáveis “num1” e “num2”. A seguir, 
            calcule a soma entre elas e atribua à variável “soma”. A seguir escrever o valor 
            desta variável.
            Exemplos de Entrada Exemplos de Saída
            30
            10
            Soma = 40
            -30
            10
            Soma = -20
            0
            0
            Soma = 0
             */

            int num1 = 0;
            int num2 = 0;

            int i = 0;

            while (i == 0)
            {

                Console.WriteLine("escreva um valor para a variável valor1:");

                try
                {
                    num1 = Int32.Parse(Console.ReadLine());
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

                Console.WriteLine("escreva um valor para a variável valor2:");

                try
                {
                    num2 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é um Integer. Tente novamente");
                }
            }

            int soma = num1 + num2;

            Console.WriteLine("O resultado da sua soma é: " + soma);
            Console.ReadLine();
        }

    }
    }
}
