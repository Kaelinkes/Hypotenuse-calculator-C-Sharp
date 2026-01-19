using System;

namespace Hypotenuse_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;

            Console.WriteLine("Welcome to my Hypotenuse calculator");

            Console.Write("Enter side A: ");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter side B: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            Console.WriteLine("The Hypotenuse is "+ c);
        }
    }
}