using System;

namespace CSharp_Loops4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4). Elabore um programa em C# que seja capaz de contar a quantidade de números ímpares
                 existentes entre dois números fornecidos pelo usuário.
             */

            int valor1 = 0;
            int valor2 = 0;

            int i = 0;

            while (i == 0)
            {
                try
                {
                    Console.WriteLine("Insira um número inteiro ");
                    valor1 = Int32.Parse(Console.ReadLine());

                    i = 1;
                }
                catch
                {
                    Console.WriteLine("Valor inserido é inválido.");
                }
            }

            i = 0;

            while (i == 0)
            {
                try
                {
                    Console.WriteLine("Insira outro número inteiro, que deve ser maior que o primeiro:");
                    valor2 = Int32.Parse(Console.ReadLine());

                    if (valor2 > valor1)
                    {
                        i = 1;
                    }

                    else
                    {
                        Console.WriteLine("Valor inserido é inválido.");
                    }
                }
                catch
                {
                    Console.WriteLine("Valor inserido é inválido.");
                }
            }

            int valorTotal = valor2 - valor1;
            int contador = 0;

            for (i = 0; i < valorTotal; i++)
            {
                if(i % 2 != 0)
                {
                    contador++;
                }
            }

            Console.WriteLine(contador);
            Console.ReadLine();
        }
    }
}
