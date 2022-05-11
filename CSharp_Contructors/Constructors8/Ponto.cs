using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors8
{
    internal class Ponto
    {
        //Crie uma classe chamada Ponto, que armazene as coordenadas (x, y) de um ponto num plano. A coordenada
        //default(padrão) para qualquer ponto deve ser(0.0, 0.0).
        //a) Além do construtor sem parâmetro, esta classe deve conter um construtor que receba como
        //parâmetros os valores de x e y.
        //b) Crie um método para calcular a distância de 2 pontos(x1, y1) e(x2, y2).Este método receberá
        //como parâmetro um objeto da classe Ponto e retornará a distância entre os pontos.
        //c) Crie uma classe de Teste e calcule a distância de 2 pontos e exiba o resultado na tela.

        public float X { get; set; }
        public float Y { get; set; }

        public Ponto() { }

        public Ponto(float x, float y) 
        {
            X = x;
            Y = y;
        }

        public float CalcularDistancia(float x, float y)
        {
            float dx = X - x;
            float dy = Y - y;

            float distancia = (float)(Math.Sqrt(dx * dx + dy * dy));

            return distancia;
        }

    }
}
