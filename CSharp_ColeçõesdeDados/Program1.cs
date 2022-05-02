using System;

namespace CSharp_ColeçõesdeDados1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1). Faça um programa em C# que receba do usuário sete números inteiros, calcule e mostre: 
                  a). Os números múltiplos de 2;
                  b). Os números múltiplos de 3;*/

            int[] numeros = new int[7];

            Console.WriteLine("Você deverá inserir 7 números inteiros.");

            int i = 0;
            int j = 0;

            for (i = 0; i < 7; i++) 
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

            Console.WriteLine("Numeros múltiplos de 2:");

            for (i = 0; i < 7; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("Numeros múltiplos de 3:");

            for (i = 0; i < 7; i++)
            {
                if (numeros[i] % 3 == 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
