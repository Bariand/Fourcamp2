using System;
using System.Linq;

namespace CSharp_ColeçõesdeDados3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3). Faça um programa em C# que receba o total de vendas de cada vendedor de uma loja e 
                  armazene-as em uma lista. Receba também o percentual de comissão a que cada vendedor 
                  tem direito e armazene-os em outra lista. Receba os nomes desses vendedores e armazene-os 
                  em uma terceira lista. 
                  Observação: Existem apenas 10 vendedores na loja. 
                  Calcule e mostre: 
                  a). Um relatório com os nomes dos vendedores e os valores a receber referentes á comissão; 
                  b) O total das vendas de todos os vendedores; 
                  c) O maior valor a receber e o nome de quem o receberá; 
                  d) O menor valor a receber e o nome de quem o receberá;*/

            string[] nomeDoVendedor = new string[10];
            int[] totalDeVendas = new int[10];
            int[] percentualDeComissão = new int[10];
            int totalDeTodasAsVendas = 0;
            int[] valorAReceber = new int[10];

            int i = 0;
            int j = 0;

            for (i = 0; i < 10; i++)
            {
                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Nome do " + (i + 1) + "º vendedor: ");
                    try
                    {
                        nomeDoVendedor[i] = Console.ReadLine();
                        j = 1;
                    }
                    catch
                    {
                        Console.WriteLine("O valor inserido não é válido.");
                    }
                }

                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Número de vendas do " + (i + 1) + "º vendedor: ");
                    try
                    {
                        totalDeVendas[i] = Int32.Parse(Console.ReadLine());
                        j = 1;
                    }
                    catch
                    {
                        Console.WriteLine("O valor inserido não é válido.");
                    }
                }

                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Percentual de comissão do " + (i + 1) + "º vendedor: ");
                    try
                    {
                        percentualDeComissão[i] = Int32.Parse(Console.ReadLine());
                        j = 1;
                    }
                    catch
                    {
                        Console.WriteLine("O valor inserido não é válido.");
                    }
                }
            }


            Console.WriteLine("Valor total a receber referentes a comissão por funcionário: ");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(nomeDoVendedor[i] + ": " + (totalDeVendas[i]) * percentualDeComissão[i] / 100);
            }

            Console.WriteLine("Valor total de vendas de todos os vendedores: ");

            for (i = 0; i < 10; i++)
            {
                totalDeTodasAsVendas += totalDeVendas[i]; 
            }
            Console.WriteLine(totalDeTodasAsVendas);

            for (i = 0; i < 10; i++)
            {
                valorAReceber[i] = totalDeVendas[i] * percentualDeComissão[i] / 100;
            }

            int valorMaior = valorAReceber.Max();
            int indiceValorMaior = valorAReceber.ToList().IndexOf(valorMaior);
            int valorMenor = valorAReceber.Min();
            int indiceValorMenor = valorAReceber.ToList().IndexOf(valorMenor);

            Console.WriteLine("Funcionário que receberá o maior valor: " + nomeDoVendedor[indiceValorMaior] + "; valor: " + valorMaior);
            Console.WriteLine("Funcionário que receberá o maior valor: " + nomeDoVendedor[indiceValorMenor] + "; valor: " + valorMenor);
        }
    }
}
