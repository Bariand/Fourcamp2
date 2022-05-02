using System;

namespace CSharp_ColeçõesdeDados4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4). Faça um programa em C# que preencha uma lista com dez números reais informados pelo 
                  usuário, calcule e mostre a quantidade de números negativos e a soma dos positivos dessa 
                  lista.*/

            Console.WriteLine("Escreva um total de 10 números reais.");

            int i = 0;
            int j = 0;
            double[] numeros = new double[10];
            double somaNumeros = 0;

            for (i = 0; i < 10; i++) 
            {
                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Escreva o " + (i + 1) + " número:");

                    try
                    {
                        numeros[i] = Double.Parse(Console.ReadLine());
                        j = 1;
                    }
                    catch
                    {
                        Console.WriteLine("O valor inserido é inválido.");
                    }
                }
            }
           
            for (i = 0; i < 10; i++)
            {
                if(numeros[i] >= 0)
                {
                    somaNumeros += numeros[i];
                }
            }

            Console.WriteLine("A soma dos números positivos é: " + somaNumeros);
            Console.WriteLine("Abaixo a lista de números negativos inseridos:");

            for (i = 0; i < 10; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}
