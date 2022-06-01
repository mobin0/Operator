using System;

namespace Operators
{
    internal class Program
    {
        //add, divide, multiply, subtract
        static int[] Arith(int a, int b)
        {
            //int a = 17; int b = 4;
            int add = a + b;
            int division = a / b; int mod = a % b;
            int multiply = a * b; int subtraction = a - b;
          
            int[] results = new int[] { add, division, mod, multiply, subtraction };
            return results;
        }

        static double Area() {
            var radius = double.Parse(Console.ReadLine());
            return Math.Pow(radius, 2) * Math.PI;
        }
        static void Main(string[] args)
        {
            int[] AR = Arith(17, 4);
            int add = AR[0];
            int divide = AR[1];
            int mod = AR[2];
            int multiply = AR[3];
            int subtraction = AR[4];
            Console.WriteLine($"a/b = {divide} with remainder {mod}");
            double sphereArea = Area();
            Console.WriteLine($"The Area of the Circle is {sphereArea}");
            //Console.WriteLine();
            


        }
    }
}
