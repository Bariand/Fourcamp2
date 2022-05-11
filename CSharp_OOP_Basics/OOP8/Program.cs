using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    internal class Program
    {
        static void MensagemDeErro()
        {
            Console.WriteLine("O valor inserido não é válido. Pressione qualquer tecla para continuar.");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Crie um programa em C# para calcular a média aritmética das notas de um aluno para uma 
            //determinada disciplina, considerando que um aluno possui apenas uma disciplina e que para esta
            //disciplina foram realizadas 3 provas. Para isso:

            //1.Crie uma classe chamada Disciplina: 
            //a.Crie a propriedade Notas do tipo List<double> para guardar as 3 notas.
            //b.Crie um método chamado ObterMedia, que fará o cálculo da média das 3 notas e
            //retornará o valor da média.

            //2.Crie uma classe chamada Aluno: 
            //a.Crie as propriedades Disciplina(do tipo Disciplina) e Nome.
            //b.Crie um método chamado AtribuirNotas, que receberá como parâmetro as 3 notas e
            //atribuirá essas notas a propriedade Notas(da classe Disciplina).

            //3.Crie um programa que receba o nome e as 3 notas do aluno e que use todos os métodos e
            //propriedades criadas nas classes. Exiba a partir de um objeto da classe aluno a mensagem no
            //console: "O aluno <nome do aluno> obteve media <media do aluno>.

            Aluno aluno = new Aluno();
            aluno.Nome = "Pantro";
            Disciplina disciplina = new Disciplina();
            aluno.Disciplina = disciplina;
            List<double> notas = new List<double>();

            int i = 0;
            int j = 0;
            double nota = 0;

            for (i = 0; i < 3; i++)
            {
                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Insira a nota da " + (i + 1) + "ª prova: ");

                    try
                    {
                        nota = Double.Parse(Console.ReadLine());
                        notas.Add(nota);
                                    
                        j = 1;
                    }
                    catch
                    {
                        MensagemDeErro();
                    }
                }
            }
            aluno.AtribuirNotas(notas[0], notas[1], notas[2]);
        }
    }
}
