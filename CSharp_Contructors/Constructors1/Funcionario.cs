using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors1
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public long Matricula { get; set; }
        public Profissao Profissao { get; set; }
        public double salario { get; set; }

        Funcionario() 
        {

        }

        Funcionario(long matricula)
        {

        }
        Funcionario(long matricula, string nome)
        {

        }
        Funcionario(long matricula, string nome, Profissao profissao)
        {

        }
        void ExibirDadosFuncionario()
        {

        }
    }
}
