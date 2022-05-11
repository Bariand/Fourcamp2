using System;

namespace Constructors9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 09
            //Crie uma classe chamada Cor
            //1.Crie as propriedades do tipo inteiro Red, Green e Blue
            //2.Forneça os construtores apropriados para possibilitar as seguintes instanciações:
            //a.Cor cor1 = new Cor(10, 100, 20); //red,green,blue
            //b.Cor cor2 = new Cor(125, 30); //red,green
            //c.Cor cor3 = new Cor(50); //red
            //d.Cor cor4 = new Cor();
            //3.Crie um método na classe Cor chamada ObterCor que retornará uma string no formato:
            //"(<red>,<green>,<blue>)“
            //4.No arquivo Program.cs, realizar as instanciações definidas nos itens I, II, III e IV e exibir as cores.

            Cor cor1 = new Cor(10, 100, 20);
            Cor cor2 = new Cor(125, 30);
            Cor cor3 = new Cor(50);
            Cor cor4 = new Cor();

            Console.WriteLine("Cor 1: " + cor1.ObterCor());
            Console.WriteLine("Cor 2: " + cor2.ObterCor());
            Console.WriteLine("Cor 3: " + cor3.ObterCor());
            Console.WriteLine("Cor 4: " + cor4.ObterCor());

            Console.ReadLine();
        }
    }
}
