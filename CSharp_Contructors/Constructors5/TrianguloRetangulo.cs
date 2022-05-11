using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors5
{
    internal class TrianguloRetangulo
    {
        //c) Crie um construtor que receberá como parâmetros os catetos (cateto1 e cateto2) e atribuirá esses
        //valores aos respectivas propriedades.
        //d) Crie um método chamado CalcularHipotenusa, sem parâmetros de entrada para realizar o cálculo
        //da hipotenusa e retornar o seu tamanho (ver dica no próximo slide).

        public double Cateto1 { get; set; }
        public double Cateto2 { get; set; }

        public TrianguloRetangulo() { }
        public TrianguloRetangulo(double cateto1, double cateto2)
        {
            Cateto1 = cateto1;
            Cateto2 = cateto2;
        }

        public double CalcularHipotenusa()
        {

            double valorHipotenusa = Math.Sqrt(Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2));
            return valorHipotenusa;
        }
    }
}
