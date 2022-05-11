using System;

namespace Constructors5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada TrianguloRetangulo
            //Crie as propriedades Cateto1 e Cateto2
            //b) Declare o construtor padrão para a classe TrianguloRetangulo.
            //c) Crie um construtor que receberá como parâmetros os catetos(cateto1 e cateto2) e atribuirá esses
            //valores aos respectivas propriedades.
            //d) Crie um método chamado CalcularHipotenusa, sem parâmetros de entrada para realizar o cálculo
            //da hipotenusa e retornar o seu tamanho(ver dica no próximo slide).
            //e) No arquivo Program.cs
            //➢ Crie 2 objetos: o primeiro utilizando o construtor padrão, com catetos de tamanho 5 e 10 e o
            //segundo utilizando o construtor de classe criado no item c, com catetos de tamanho 4 e 5.
            //➢ Exiba na tela os valores das hipotenusas.

            TrianguloRetangulo trianguloRetangulo1 = new TrianguloRetangulo() {};

            trianguloRetangulo1.Cateto1 = 5;
            trianguloRetangulo1.Cateto2 = 10;

            TrianguloRetangulo trianguloRetangulo2 = new TrianguloRetangulo(4, 5);

            Console.WriteLine("Hipotenusa do triângulo 1 = " + trianguloRetangulo1.CalcularHipotenusa());
            Console.WriteLine("Hipotenusa do triângulo 2 = " + trianguloRetangulo2.CalcularHipotenusa());

            Console.ReadLine();
        }
    }
}
