using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSharp_ComplementoOOI1
{
    internal class Circulo : FormaPlana
    {
        public double PI { get; } = 3.1416;
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            double area = PI * (Raio * Raio);
            return area;
        }
    }
}
