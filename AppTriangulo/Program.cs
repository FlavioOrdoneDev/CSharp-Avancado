using System;

namespace AppTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X = new Triangulo(3, 4, 5);
            Triangulo Y = new Triangulo(7.5, 4.5, 4.02);

            double areaX = X.CalcularArea();
            double areaY = Y.CalcularArea();            

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
                Console.WriteLine("Maior area: X");
            else
                Console.WriteLine("Maior area: Y");
            
            Console.ReadKey();
        }
    }
}
