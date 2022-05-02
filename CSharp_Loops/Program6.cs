using System;

namespace CSharp_Loops6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6). Faça um programa em C# que leia 50 idades e mostre na tela a média simples das idades
                 digitadas.
                 Observações:
                 - Não aceitar idade < 0
                 - Necessariamente precisa ter 50 idades válidas
             */

            int[] idade = new int[50];
            int i = 0;

            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("Escreva uma idade nº " + (i + 1) + " de 50:");

                try
                {
                    idade[i] = Int32.Parse(Console.ReadLine());
                    
                    if(idade[i] < 0)
                    {
                        Console.WriteLine("O valor inserido é inválido.");
                        i -= 1;
                    }
                }
                catch
                {
                    Console.WriteLine("O valor inserido é inválido.");
                    i -= 1;
                }
            }

            int idadeTotal = 0;

            for (i = 0; i < 50; i++)
            {
                    idadeTotal += idade[i];
            }

            Console.WriteLine("A média de todos os alunos é: " + idadeTotal / 50);
            Console.ReadLine();
        }
    }
}
