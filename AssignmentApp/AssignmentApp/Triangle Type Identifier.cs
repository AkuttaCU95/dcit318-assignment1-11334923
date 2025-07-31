using System;

namespace AssignmentApp
{
    internal class Triangle_Type_Identifier
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Triangle Type Identifier-----");

            double side1 = GetSideLength("Enter length of side 1: ");
            double side2 = GetSideLength("Enter length of side 2: ");
            double side3 = GetSideLength("Enter length of side 3: ");

            if (!IsValidTriangle(side1, side2, side3))
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
                return;
            }

            string triangleType = GetTriangleType(side1, side2, side3);
            Console.WriteLine($"The triangle is: {triangleType}");
        }

        static double GetSideLength(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double length) && length > 0)
                    return length;
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            // Triangle inequality theorem
            return a + b > c && a + c > b && b + c > a;
        }

        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilateral";
            else if (a == b || b == c || a == c)
                return "Isosceles";
            else
                return "Scalene";
        }
    }
}