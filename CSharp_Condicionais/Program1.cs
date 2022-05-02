using System;

namespace CSharp_Condicionais1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1). Faça um programa em C# que receba dois números inteiros e mostre na tela o maior 
            número digitado.
            */

            int numero1 = 0;
            int numero2 = 0;

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("Escreve um número inteiro: ");

                try
                {
                    numero1 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é válido. ");
                }
            }

            i = 0;

            while (i == 0)
            {
                Console.WriteLine("Escreve outro número inteiro: ");

                try
                {
                    numero2 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é válido. ");
                }
            }

            if (numero1 > numero2)
            {
                Console.WriteLine("Você digitou os valores " + numero1 + " e " + numero2 + ", sendo " + numero1 + " maior que " + numero2);
                Console.ReadLine();
            }

            else if (numero1 < numero2)
            {
                Console.WriteLine("Você digitou os valores " + numero1 + " e " + numero2 + ", sendo " + numero2 + " maior que " + numero1);
                Console.ReadLine();
            }

            else if (numero1 == numero2)
            {
                Console.WriteLine("Você digitou o número " + numero1 + " duas vezes!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Algo de errado não está certo...");
                Console.ReadLine();
            }
        }
    }
}
