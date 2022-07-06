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

            var product = a * b;

            Console.WriteLine($"{a}*{b} is {product}");

            var result = a + b;

            Console.WriteLine($"{a}+{b} is {result}");

            var difference = a - b;

            Console.WriteLine($"{a}-{b} is {difference}");

        }

        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");

            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"The area of a circle with radius {r} is {area}");
        }
    }
}
