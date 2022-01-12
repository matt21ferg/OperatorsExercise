using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4) ;
            {
                Console.WriteLine($"({a}/{ b} is { quotient } remainder { remainder}");

            }
            int c = 4;
            int d = 65;
            int sum = c + d;
            Console.WriteLine(sum);

            int e = 656;
            int f = 254;
            int difference = e - f;
            Console.WriteLine(difference);

            int g = 89;
            int h = 44;
            int product = g * h;
            Console.WriteLine(product);
            Console.WriteLine (AreaOfCircle());
        }
        public static double AreaOfCircle()
        {
            double pi = 3.14;
            Console.WriteLine("how big is your radius");
            var radius = double.Parse(Console.ReadLine());

            return pi * radius * radius;
           



        }
    }
}
