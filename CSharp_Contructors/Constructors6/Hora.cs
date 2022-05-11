using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor6
{
    internal class Hora
    {
        //a) Crie as propriedades Hora, Minuto e Segundo
        //b) Crie um construtor que receba 3 parâmetros: a hora, o minuto e o segundo e em seguida
        //atribua esses valores as respectivas propriedades da classe.
        //c) Crie um método chamado ObterHora, para retornar a hora, no formato: hh: mm: ss

        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public Hora(int horas, int minutos, int segundos)
        {
            Horas = horas;
            Minutos = minutos;
            Segundos = segundos;
        }

        public string ObterHora()
        {
            string horario = (string)(Horas + ":" + Minutos + ":" + Segundos);
            return horario;
        }
    }
}
