using System;

namespace CSharp_Condicionais3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3). Faça um programa em C# que receba do usuário três números inteiros e mostre-os na tela 
                em ordem crescente. Caso o usuário digite três números iguais, mostrar na tela a informação: 
                OS TRÊS NÚMEROS DIGITADOS SÃO IGUAIS.
             */

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

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

            i = 0;

            while (i == 0)
            {
                Console.WriteLine("Escreve outro número inteiro: ");

                try
                {
                    numero3 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é válido. ");
                }
            }

            Console.WriteLine("Em ordem crescrescente, os numeros que você digitou foram: ");

            if (numero1 > numero2 && numero1 > numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero3 + "; " + numero2 + "; " + numero1);
            }

            else if (numero1 > numero2 && numero1 > numero3 && numero2 < numero3)
            {
                Console.WriteLine(numero2 + "; " + numero3 + "; " + numero1);
            }

            else if (numero1 < numero2 && numero1 > numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero3 + "; " + numero1 + "; " + numero2);
            }

            else if (numero1 < numero2 && numero1 > numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero1 + "; " + numero3 + "; " + numero2);
            }

            else if (numero1 < numero2 && numero1 < numero3 && numero2 < numero3)
            {
                Console.WriteLine(numero1 + "; " + numero2 + "; " + numero3);
            }

            else if (numero1 < numero2 && numero1 < numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero1 + "; " + numero3 + "; " + numero2);
            }

            else if (numero1 == numero3 && numero2 == numero3)
            {
                Console.WriteLine("Todos os números que você digitou são iguais, não sendo possível ordená-los.");
            }

            else if (numero1 == numero3 || numero2 == numero3 || numero2 == numero1)
            {
                Console.WriteLine("Você digitou dois números iguais, não sendo possível ordená-los.");
            }

            else
            {
                Console.WriteLine("Algo errado não está certo...");
            }

            Console.ReadLine();
        }
    }
}
