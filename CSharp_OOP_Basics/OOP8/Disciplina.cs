using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    internal class Disciplina
    {
        //1.Crie uma classe chamada Disciplina: 

        
        //a.Crie a propriedade Notas do tipo List<double> para guardar as 3 notas.
        public List<double> Notas { get; set; }

        //b.Crie um método chamado ObterMedia, que fará o cálculo da média das 3 notas e
        //retornará o valor da média.

        public double ObterMedia(double nota1, double nota2, double nota3)
        {
            double media = (nota1 + nota2 + nota3) / 3;
                return media;
        }
    }
}
