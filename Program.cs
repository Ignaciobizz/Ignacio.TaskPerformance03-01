using System;

namespace MathApp
{
    class MathProgram
    {
        static void Main(string[] args)
        {

            double firstNum = 15.75;
            double secondNum = -20.0;
            double myBase = 2.0;
            double myPower = 3.0;

            Console.WriteLine("Absolute value of " + secondNum + " is: " + Math.Abs(secondNum));
            Console.WriteLine("Higher value between " + firstNum + " and 10 is: " + Math.Max(firstNum, 10));
            Console.WriteLine(myBase + " to the power of " + myPower + " is: " + Math.Pow(myBase, myPower));
            Console.WriteLine("Square root of 144 is: " + Math.Sqrt(144));
            Console.WriteLine("Ceiling value of " + firstNum + " is: " + Math.Ceiling(firstNum));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}