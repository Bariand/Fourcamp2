using System;

namespace OOP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa em C# que solicite ao usuário um numero de quantos produtos serão cadastrados. Após 
            //isso peça suas respectivas quantidades, preços e descontos (valores em R$). 
            //Mostrar ao final valor total a ser pago.
            //Obrigatório:
            //Criar uma classe para produto.
            //Utilizar objetos dessa classe em seu programa.

            int i = 0;
            int input1 = 0;
            double valorTotal = 0;

            Console.WriteLine("Quantos produtos você quer cadastrar? ");

            while (i == 0)
            {
                try
                {
                    input1 = Int32.Parse(Console.ReadLine());                
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor inserido é inválido.");
                    Console.ReadLine();
                }
            }

            Produto[] produto = new Produto[input1];

            //Iteração para realizar os cadastros dos produtos
            for (i = 0; i < input1; i++)
            {
                produto[i] = new Produto();
                produto[i].Cadastrar();
            }

            //Iteração para calcular o valor final de todos os produtos
            for (i = 0; i < input1; i++)
            {
                valorTotal += produto[i].QuantidadeProduto * produto[i].PrecoProduto - produto[i].QuantidadeProduto * produto[i].PrecoProduto * produto[i].DescontoProduto / 100;
            }

            Console.WriteLine("Total a pagar: R$ " + valorTotal.ToString("0.00"));
            Console.ReadLine();
        }
    }
}
