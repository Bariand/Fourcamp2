using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    internal class Aluno
    {
        //2.Crie uma classe chamada Aluno: 

        //a.Crie as propriedades Disciplina (do tipo Disciplina) e Nome.
        public Disciplina Disciplina { get; set; }
        public string Nome { get; set; }

        //b.Crie um método chamado AtribuirNotas, que receberá como parâmetro as 3 notas e
        //atribuirá essas notas à propriedade Notas (da classe Disciplina).

        public void AtribuirNotas(double nota1, double nota2, double nota3)
        {
            List<double> notasAN = new List<double>();
            notasAN.Add(nota1);
            notasAN.Add(nota2);
            notasAN.Add(nota3);

            Disciplina disciplina = new Disciplina();
            double media = disciplina.ObterMedia(nota1, nota2, nota3);

            Console.WriteLine("O aluno " + Nome + " obteve media " + media);
            Console.ReadLine();
        }
    }
}
