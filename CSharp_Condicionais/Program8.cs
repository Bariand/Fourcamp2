using System;

namespace CSharp_Condicionais8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             8). A prefeitura de Recife criou um programa de empréstimo para seus funcionários com 
                desconto em folha. O valor da prestação não pode ultrapassar 30% do salário bruto do 
                funcionário. Faça um programa em C# que solicite o valor do salário bruto, o valor da 
                prestação e informe se o empréstimo pode ou não ser concedido. 
                Validações: 
                Não aceitar salário <= 0 
                Não aceitar prestação <= 0
             */

            float salarioBruto = 0f;
            float valorPrestaçao = 0f;

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("Digite o valor do salário bruto: ");

                try
                {
                    salarioBruto = float.Parse(Console.ReadLine());
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
                Console.WriteLine("Digite o valor da prestação a ser descontada em folha (máx. 30% do salário bruto:");

                try
                {
                    valorPrestaçao = float.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {

                    Console.WriteLine("O valor que você digitou não é válido.");
                }
            }

            if (valorPrestaçao <= salarioBruto * 30 / 100)
            {
                Console.WriteLine("Empréstimo passível de aprovação.");
            }

            else
            {
                Console.WriteLine("Empréstimo não passível de aprovação. O valor da prestação excedeu os 30% do salário bruto.");
                Console.ReadLine();
            }
        }
    }
}
