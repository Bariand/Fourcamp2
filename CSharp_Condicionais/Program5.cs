using System;

namespace CSharp_Condicionais5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5). Faça um programa em C# que solicite ao usuário um número inteiro e retorne se é par ou 
                ímpar
             */

            int numero1 = 0;

            int i = 0;

            while (i == 0) 
            {
                Console.WriteLine("Digite um número inteiro: ");

                try
                {
                    numero1 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {

                    Console.WriteLine("O valor que você digitou não é válido.");
                }
            }

            if (numero1 % 2 == 0)
            {
                Console.WriteLine("O número digitado é par.");
            }

            else
            {
                Console.WriteLine("O número digitado é impar.");
            }
        }
    }
}
