using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSharp_ComplementoOOI1
{
    internal class Triangulo : FormaPlana
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double _base, double altura) 
        {
            Base = _base;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            double area = (Base * Altura) / 2;
            return area;
        }
    }
}
