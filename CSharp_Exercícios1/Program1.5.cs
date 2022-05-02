using System;

namespace CSharp_Exercícios1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do 
            produto de A e B pelo produto de C e D segundo a fórmula:
            DIFERENCA = (A * B - C * D).
            Entrada
            O arquivo de entrada contém 4 valores inteiros.
            Exemplos de Entrada Exemplos de Saída
            5
            6
            7
            8
            DIFERENCA = -26
            0
            0
            7
            8
            DIFERENCA = -56
            5
            6
            -7
            8
            DIFERENCA = 86

                         */

            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int valor4 = 0;

            int i = 0;

            Console.WriteLine("Será feita a seguinte operação: valor1 * valor2 - valor3 * valor4");

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

            i = 0;

            while (i == 0)
            {

                Console.WriteLine("Escreva um valor para a variável valor3:");

                try
                {
                    valor3 = Int32.Parse(Console.ReadLine());
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

                Console.WriteLine("Escreva um valor para a variável valor4:");

                try
                {
                    valor4 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é um Integer. Tente novamente");
                }
            }

            int diferença = (valor1 * valor2 - valor3 * valor4);

            Console.WriteLine("O resultado da sua soma é: " + diferença);
            Console.ReadLine();
        }
    }
}
