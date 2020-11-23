using System;

namespace AppDelegates
{
    delegate double NumericOperation(double n1, double n2);
    delegate void ShowOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            NumericOperation numeric = CalculationService.Sum;
            ShowOperation show = CalculationService.ShowSum;
            show += CalculationService.ShowMax;

            show.Invoke(a, b);

            Console.WriteLine(numeric(a, b));

            Console.ReadKey();
        }
    }

    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return x * x;
        }

        public static void ShowMax(double x, double y)
        {
            double result = (x > y) ? x : y;
            Console.WriteLine("Max: " + result);
        }

        public static void ShowSum(double x, double y)
        {
            double result = x + y;
            Console.WriteLine("Sum: " + result);
        }
    }
}
