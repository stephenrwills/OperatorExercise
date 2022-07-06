using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Exercises
    {
        public static void Exercise1()
        {
            var a = 17;
            var b = 4;

            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            int x = 10;
            int y = 20;

            x += y;
            Console.WriteLine(x);
            x -= y;
            Console.WriteLine(x);
            x *= y;
            Console.WriteLine(x);

            //var product = a * b;

            //Console.WriteLine($"{a}*{b} is {product}");

            //var result = a + b;

            //Console.WriteLine($"{a}+{b} is {result}");

            //var difference = a - b;

            //Console.WriteLine($"{a}-{b} is {difference}");

        }

        public static double AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");

            double radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);

            return area;

            Console.WriteLine($"The area of a circle with radius {radius} is {area}");
        }
    }
}
