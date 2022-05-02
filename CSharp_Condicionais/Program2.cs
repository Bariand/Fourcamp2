using System;

namespace CSharp_Condicionais2
{
    internal class Program
    {

        /*
         2). Escreva um programa em C# que receba 3 números reais e mostre-os na tela em ordem 
            decrescente. Considere que o usuário digitará 3 números diferentes.
         */

        static void Main(string[] args)
        {
            float numero1 = 0f;
            float numero2 = 0f;
            float numero3 = 0f;

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("Escreve um número real: ");

                try
                {
                    numero1 = float.Parse(Console.ReadLine());
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
                Console.WriteLine("Escreve um número real diferente do anterior: ");

                try
                {
                    numero2 = float.Parse(Console.ReadLine());

                    if (numero1 != numero2)
                    {
                        i = 1;
                    }

                    else 
                    {
                        Console.WriteLine("O valor que você digitou não é válido. ");
                    }
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é válido. ");
                }
            }

            i = 0;

            while (i == 0)
            {
                Console.WriteLine("Escreve um número real diferente do anterior: ");

                try
                {
                    numero3 = float.Parse(Console.ReadLine());

                    if (numero3 != numero1 && numero3 != numero2)
                    {
                        i = 1;
                    }

                    else
                    {
                        Console.WriteLine("O valor que você digitou não é válido. ");
                    }
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é válido. ");
                }
            }

            Console.WriteLine("Em ordem descrescente, os numeros que você digitou foram: ");

            if (numero1 > numero2 && numero1 > numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero1 + "; " + numero2 + "; " + numero3);
            }

            else if (numero1 > numero2 && numero1 > numero3 && numero2 < numero3)
            {
                Console.WriteLine(numero1 + "; " + numero3 + "; " + numero2);
            }

            else if (numero1 < numero2 && numero1 > numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero2 + "; " + numero1 + "; " + numero3);
            }

            else if (numero1 < numero2 && numero1 > numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero2 + "; " + numero3 + "; " + numero1);
            }

            else if (numero1 < numero2 && numero1 < numero3 && numero2 < numero3)
            {
                Console.WriteLine(numero3 + "; " + numero2 + "; " + numero1);
            }

            else if (numero1 < numero2 && numero1 < numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero2 + "; " + numero3 + "; " + numero1);
            }

            else 
            {
                Console.WriteLine("Algo errado não está certo...");
            }

            Console.ReadLine();
        }
    }
}
