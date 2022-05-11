using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors9
{
    internal class Cor
    {
        //1.Crie as propriedades do tipo inteiro Red, Green e Blue
        //2.Forneça os construtores apropriados para possibilitar as seguintes instanciações:
        //a.Cor cor1 = new Cor(10, 100, 20); //red,green,blue
        //b.Cor cor2 = new Cor(125, 30); //red,green
        //c.Cor cor3 = new Cor(50); //red
        //d.Cor cor4 = new Cor();
        //3.Crie um método na classe Cor chamada ObterCor que retornará uma string no formato:
        //"(<red>,<green>,<blue>)“

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Cor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public Cor(int red, int green) 
        {
            Red = red;
            Green = green;
        }

        public Cor(int red) 
        {
            Red = red;
        }

        public Cor() { }

        public string ObterCor()
        {
            return (string)(Red + ", " + Green + ", " + Blue);
        }
    }
}
