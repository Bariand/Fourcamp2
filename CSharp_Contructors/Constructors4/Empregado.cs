using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors4
{
    internal class Empregado
    {
        //a) Crie as propriedades Nome, Funcao e Salario
        //b) Crie um construtor que receba como parâmetros o nome, função e salário do empregado e depois
        //inicialize as respectivas propriedades.
        //c) Crie um método chamado AumentarSalario, que receberá como parâmetro o valor do aumento.
        //Este método deverá atualizar o salário do empregado.

        public string Nome { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
        public double SalarioFinal { get; set; }

        public Empregado(string nome, string funcao, int salario)
        {
            Nome = nome;
            Funcao = funcao;
            Salario = salario;
        }

        public double AumentarSalario(double valorDoAumento)
        {
            SalarioFinal = Salario += valorDoAumento;
            return SalarioFinal;
        }
     }
}
