using System;
using System.Collections.Generic;
using System.Text;

namespace AppTriangulo
{
    public class Triangulo
    {
        public double CalcularArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
