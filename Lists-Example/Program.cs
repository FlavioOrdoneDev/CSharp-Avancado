using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();

            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twoPointTwo = "2.2";

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);

            if (a.Contains("three"))
            {
                a.Add("four");
            }

            a.RemoveAt(2);

            if (a.IndexOf("four") != 4)
            {
                a.Add(fourth);
            }

            if (a.Contains("two"))
            {
                a.Add(twoPointTwo);
            }

            PrintL(a);

            Console.ReadKey();
        }

        public static void PrintL(List<string> a)
        {
            string result = "";

            foreach (var item in a)
            {
                result += "\n" + item;
            }

            Console.WriteLine(result);
        }
    }

}
