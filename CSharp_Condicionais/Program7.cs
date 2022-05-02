using System;

namespace CSharp_Condicionais7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7). Escreva um programa em C# que receba dois números reais. Verifique se a soma dos 
                números digitados é maior que 10 e mostre na tela:
                Se a soma for maior que 10, mostrar na tela: Número maior que 10.
                Se a soma for menor ou igual a 10, mostrar na tela: Número menor ou igual a 10.
             */


            float numero1 = 0f;
            float numero2 = 0f;

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("Digite um número real: ");

                try
                {
                    numero1 = float.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {

                    Console.WriteLine("O valor que você digitou não é válido.");
                }
            }

            i = 0;

            while (i == 0)
            {
                Console.WriteLine("Digite outro número real: ");

                try
                {
                    numero2 = float.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {

                    Console.WriteLine("O valor que você digitou não é válido.");
                }
            }

            if (numero1 + numero2 > 10)
            {
                Console.WriteLine("A soma dos valores digitados é maior que 10.");
            }

            else
            {
                Console.WriteLine("A soma dos valores digitados é menor ou igual a 10.");
            }
        }
    }
}
