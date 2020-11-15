using System;

namespace AppTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            double areaX = X.CalcularArea(3, 4, 5);
            double areaY = Y.CalcularArea(7.5, 4.5, 4.02);            

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
                Console.WriteLine("Maior area: X");
            else
                Console.WriteLine("Maior area: X");
            
            Console.ReadKey();
        }
    }
}
