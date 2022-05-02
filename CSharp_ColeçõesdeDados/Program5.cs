using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_ColeçõesdeDados5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5) Faça um programa em C# que solicite ao usuário 10 números inteiros. Guardar os números 
                 em uma lista. 
                 Mostrar na tela: 
                 a) Quantos números se repetem. 
                 b) Quantas vezes eles aparecem. 
                 Exemplo: 
                 5 7 3 2 10 2 7 2 5 2
                 Números que aparecem mais de uma vez na lista e quantas vezes aparecem: 
                 5 – 2 vezes 
                 7 – 2 vezes 
                 2 – 4 vezes*/

            Console.WriteLine("Escreva um total de 10 números inteiros.");

            int i = 0;
            int j = 0;
            int input = 0;
            List<int> numeros = new List<int>();
            List<int> numerosRepetidos = new List<int>();

            for (i = 0; i < 10; i++)
            {
                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Escreva o " + (i + 1) + " número:");

                    try
                    {
                        input = Int32.Parse(Console.ReadLine());
                        numeros.Add(input);
                        j = 1;
                    }
                    catch 
                    {
                        Console.WriteLine("O número inserido não é válido");
                    }
                }
            }

            Dictionary<int, int> frequencia = numeros.GroupBy(x => x)
                                            .Where(g => g.Count() > 1)
                                            .ToDictionary(x => x.Key, x => x.Count());

            Console.WriteLine("[Valor, Repetições]: " + String.Join(", ", frequencia));

        }
    }
}
