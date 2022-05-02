using System;

namespace CSharp_Condicionais6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             6). Faça um programa em C# que solicite ao usuário um número inteiro e retorne se é múltiplo 
                de 5 e de 10 ao mesmo tempo.
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

            if (numero1 % 5 == 0 && numero1 % 10 == 0)
            {
                Console.WriteLine("O número digitado é tanto múltiplo de 5 quanto de 10.");
            }

            else
            {
                Console.WriteLine("O número digitado não é tanto multiplo de 5 quanto de 10.");
            }
        }
    }
}
