using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors7
{
    internal class Lampada
    {
        //1.Crie as propriedades Cor do tipo String e Ligada do tipo boolean
        //2.Crie um construtor sem parâmetro.
        //3.Crie um construtor que receba 2 parâmetros: a cor e o estado da lâmpada(true ou false) e atribua
        //as respectivas propriedades.
        //4.Crie um construtor que receba apenas um parâmetro: a cor da lâmpada. Neste caso, atribua a cor a
        //respectiva propriedade e por padrão, atribua a propriedade Ligada o valor true.

        public string Cor { get; set; }
        public bool Ligada { get; set; }

        public Lampada() { }

        public Lampada(string cor, bool ligada)
        {
            Cor = cor;
            Ligada = ligada;
        }

        public Lampada(string cor)
        {
            Cor = cor;
            Ligada = true;
        }
    }
}
