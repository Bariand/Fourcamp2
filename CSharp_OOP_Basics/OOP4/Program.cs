using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa em C# para calcular o salário de um funcionário. Ao ser executado, o 
            //programa deverá solicitar ao usuário o número de horas trabalhadas e o valor da hora de trabalho
            //e então deverá exibir no console o salário a ser pago. Para o cálculo do salário utilize a seguinte
            //fórmula:
            //salario = horas trabalhadas* valor da hora de trabalho
            //Obrigatório:
            //Criar uma classe para funcionário.
            //Utilizar objetos dessa classe em seu programa.
            //Criar um método para calcular o salario.

            Funcionario funcionario1 = new Funcionario();
            funcionario1.NomeFuncionario = "Dilbert";
            funcionario1.NumeroHoras = 300;
            funcionario1.ValorHora = 80;

            Funcionario funcionario2 = new Funcionario();
            funcionario2.NomeFuncionario = "Wally";
            funcionario2.NumeroHoras = 10;
            funcionario2.ValorHora = 3000;

            Funcionario funcionario3 = new Funcionario();
            funcionario3.NomeFuncionario = "Alice";
            funcionario3.NumeroHoras = 300;
            funcionario3.ValorHora = 80;

            int i = 0;
            int j = 0;
            int input1 = 0;

            while(i == 0)
            {
                Console.WriteLine("Escolha de qual funcionário você quer olhar o salário:");
                Console.WriteLine("(1) Dilbert");
                Console.WriteLine("(2) Wally");
                Console.WriteLine("(3) Alice");
                Console.WriteLine("(0) Sair");

                try
                {
                    input1 = Int32.Parse(Console.ReadLine());

                    if (input1 == 0)
                    {
                        Environment.Exit(0);
                    }

                    else if (input1 == 1)
                    {
                        funcionario1.CalcularSalario();
                    }

                    else if (input1 == 2)
                    {
                        funcionario2.CalcularSalario();
                    }

                    else if (input1 == 3)
                    {
                        funcionario3.CalcularSalario();
                    }

                    else
                    {
                        Console.WriteLine("O valor inserido não é válido");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("O valor inserido não é válido");
                    Console.ReadLine();
                }
            }
        }
    }
}
