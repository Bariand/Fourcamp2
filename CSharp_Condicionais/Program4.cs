using System;

namespace CSharp_Condicionais4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             4). Escreva um programa em C# que solicite ao usuário 3 (três) números inteiros e retorne se 
                os números foram ou não foram digitados em ordem crescente.
             */

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("Escreve um número real: ");

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
                Console.WriteLine("Escreve um número real diferente do anterior: ");

                try
                {
                    numero2 = Int32.Parse(Console.ReadLine());

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
                    numero3 = Int32.Parse(Console.ReadLine());

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

            Console.WriteLine("Os numeros que você digitou foram: ");
            Console.WriteLine(numero1 + "; " + numero2 + "; " + numero3);

            if (numero1 < numero2 && numero2 < numero3)
            {
                Console.WriteLine("Estes números estão em ordem crescente");
            }

            else 
            {
                Console.WriteLine("Estes números não estão em ordem crescente.");
            }

            Console.ReadLine();
        }
    }
}
