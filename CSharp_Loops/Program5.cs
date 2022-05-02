using System;

namespace CSharp_Loops5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5). Faça um programa em C# que solicite ao usuário dois números inteiros e mostre na tela a
                 soma dos elementos existentes entre os dois números informados.
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

            int diferença = valor2 - valor1 - 1;
            int contador = 0;
            int soma = 0;

            for (i = 0; i < diferença; i++)
            {
                contador++;
                soma += contador + valor1;
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
