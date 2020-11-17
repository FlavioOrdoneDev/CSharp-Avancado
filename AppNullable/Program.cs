using System;

namespace AppNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine();

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine();

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x é nulo");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y é nulo");


            Console.WriteLine("-------------------");

            double? z = null;
            double? w = 10;

            double a = z ?? 5;
            double b = w ?? 10;

            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadKey();
        }
    }
}
