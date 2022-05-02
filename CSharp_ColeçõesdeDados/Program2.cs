using System;

namespace CSharp_ColeçõesdeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2). Faça um programa em C# que receba do usuário quinze números inteiros e verifique a 
                  existência de elementos iguais a 30, mostrando as posições na lista em que apareceram.*/

            int[] numeros = new int[15];

            Console.WriteLine("Você deverá inserir 15 números inteiros.");

            int i = 0;
            int j = 0;

            for (i = 0; i < 15; i++)
            {
                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Insira o + " + (i + 1) + "º número: ");
                    try
                    {
                        numeros[i] = Int32.Parse(Console.ReadLine());
                        j = 1;
                    }
                    catch
                    {
                        Console.WriteLine("O valor inserido não é válido.");
                        i = -1;
                    }
                }
            }

            for (i = 0; i < 15; i++)
            {
                if (numeros[i] == 30)
                {
                    Console.WriteLine("O elemento nº " + (i + 1) + " possui valor = " + numeros[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
