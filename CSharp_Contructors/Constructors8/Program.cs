using System;

namespace Constructors8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada Ponto, que armazene as coordenadas (x, y) de um ponto num plano. A coordenada
            //default(padrão) para qualquer ponto deve ser(0.0, 0.0).
            //a) Além do construtor sem parâmetro, esta classe deve conter um construtor que receba como
            //parâmetros os valores de x e y.
            //b) Crie um método para calcular a distância de 2 pontos(x1, y1) e(x2, y2).Este método receberá
            //como parâmetro um objeto da classe Ponto e retornará a distância entre os pontos.
            //c) Use o construtor sem parâmetro para instanciar o primeiro ponto e o construtor com parâmetros
            //para instanciar o segundo ponto.
            //Nota: Para calcular a distância de 2 pontos utilize a fórmula: 
            //dx = x2 - x1; dy = y2 - y1; distancia = Math.Sqrt(dx * dx + dy * dy);

            Ponto ponto1 = new Ponto(4.5f, 9.1f);
            Ponto ponto2 = new Ponto(-3.5f, 0.5f);

            Console.WriteLine(ponto1.CalcularDistancia(ponto2.X, ponto2.Y));

            Console.ReadLine();
        }
    }
}
