using System;

namespace Constructor6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada Hora
            //a) Crie as propriedades Hora, Minuto e Segundo
            //b) Crie um construtor que receba 3 parâmetros: a hora, o minuto e o segundo e em seguida
            //atribua esses valores as respectivas propriedades da classe.
            //c) Crie um método chamado ObterHora, para retornar a hora, no formato: hh: mm: ss
            //d) No arquivo Program.cs: Instanciar um objeto da classe Hora e definir seu estado de modo que ao ser
            //invocado o método ObterHora seja exibido no console a hora 12:40:15

            Hora hora1 = new Hora(12, 40, 15);

            Console.WriteLine(hora1.ObterHora());
            Console.ReadLine();
        }
    }
}
