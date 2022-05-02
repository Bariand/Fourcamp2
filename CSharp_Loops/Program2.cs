using System;

namespace CSharp_Loops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2). Faça um programa em C# que solicite ao usuário um número inteiro e mostre na tela os
             próximos 10 números inteiros a partir do número digitado.
            */

            int i = 0;
            int input = 0;

            while (i == 0) 
            {
                Console.WriteLine("Escreva um número inteiro: ");

                try
                {
                    input = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {

                    Console.WriteLine("Valor inserido não é válido.");
                }
            }

            i = 0;

            for ( i = 1; i <= 10; i++)
            {
                Console.WriteLine(input + i);
            }
            Console.ReadLine();
        }
    }
}
