using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Funcionario
    {
        public string NomeFuncionario { get; set; }
        public double NumeroHoras { get; set; }
        public double ValorHora { get; set; }

        public double Remuneracao { get; set; }     

        public void CalcularSalario()
        {
            Console.WriteLine("Salario do funcionário " + NomeFuncionario + ":");
            Console.WriteLine(" ");

            double remuneracao = NumeroHoras * ValorHora;
            Remuneracao = remuneracao;
            Console.WriteLine(Remuneracao);
            Console.ReadLine();
        }
    }
}
