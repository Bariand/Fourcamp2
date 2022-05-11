using System;

namespace Constructors4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada Empregado
            //a) Crie as propriedades Nome, Funcao e Salario
            //b) Crie um construtor que receba como parâmetros o nome, função e salário do empregado e depois
            //inicialize as respectivas propriedades.
            //c) Crie um método chamado AumentarSalario, que receberá como parâmetro o valor do aumento.
            //Este método deverá atualizar o salário do empregado.
            //d) No arquivo Program.cs:
            //a.Crie um objeto da classe Empregado que tenha como nome “João”, salário inicial de
            //R$5.400,00 e função “Analista de Sistemas”. Utilize o construtor criado no item b.
            //b.Aumente o salário deste funcionário em R$600,00, através da utilização do método criado no
            //item c.
            //c.Exiba na tela valor dos propriedades Nome, Funcao e Salario.

            Empregado empregado1 = new Empregado("João", "Analista de Sistemas", 5400);

            empregado1.AumentarSalario(600);

            Console.WriteLine("Nome: " + empregado1.Nome);
            Console.WriteLine("Função: " + empregado1.Funcao);
            Console.WriteLine("salario: " + empregado1.SalarioFinal);
            Console.ReadLine();
        }
    }
}
