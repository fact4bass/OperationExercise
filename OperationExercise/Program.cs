using System;

namespace OperationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;


            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"the area of a circle with the radius of {r} is {areaOfCircle}");









        }
    }
}
