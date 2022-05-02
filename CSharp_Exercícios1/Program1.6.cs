using System;

namespace CSharp_Exercícios1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um programa que leia o número de um funcionário, seu número de 
                horas trabalhadas, o valor que recebe por hora e calcula o salário desse 
                funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
                decimais.
                Entrada
                O arquivo de entrada contém 2 números inteiros e 1 número com duas casas 
                decimais, representando o número, quantidade de horas trabalhadas e o valor 
                que o funcionário recebe por hora trabalhada, respectivamente.
                Exemplos de Entrada Exemplos de Saída
                25
                100
                5.50
                NUMBER = 25
                SALARY = U$ 550.00
                1
                200
                20.50
                NUMBER = 1
                SALARY = U$ 4100.00
                6
                145
                15.55
                NUMBER = 6
                SALARY = U$ 2254.75
            */

            int numeroFuncionario = 0;
            int horasTrabalhadas = 0;
            float salarioHora = 0f;


            int i = 0;

            Console.WriteLine("SISTEMA Systema. O melhor sistema.");
            Console.WriteLine("....................................................");
            Console.WriteLine(" ");
            Console.ReadLine();

            while (i == 0)
            {

                Console.WriteLine("Digite o Número de Matrícula do funcionário: ");

                try
                {
                    numeroFuncionario = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é um Inteiro. Tente novamente");
                }
            }

            i = 0;

            while (i == 0)
            {

                Console.WriteLine("Digite a quantidade de horas trabalhadas, no mês em questão :");

                try
                {
                    horasTrabalhadas = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é inteiro. Tente novamente");
                }
            }

            i = 0;

            while (i == 0)
            {

                Console.WriteLine("Digite o valor do salário/hora deste funcionário :");

                try
                {
                    salarioHora = float.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é um número decimal válido. Tente novamente");
                }
            }

            float vencimento = horasTrabalhadas * salarioHora;
            string stringVencimento = vencimento.ToString("0.00");

            Console.WriteLine("Vencimento do funcionário com número de matrícula " + numeroFuncionario + ": R$" + stringVencimento + "");
            Console.ReadLine();
        }
    }
}
