using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSharp_ComplementoOOI1
{

    internal class Quadrado : FormaPlana
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            double area = Lado * Lado;
            return area;
        }
    }

}
