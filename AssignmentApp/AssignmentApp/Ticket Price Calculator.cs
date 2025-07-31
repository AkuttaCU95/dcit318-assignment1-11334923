using System;

namespace AssignmentApp
{
    internal class Ticket_Price_Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Ticket Price Calculator-----");
            Console.Write("Enter your age: ");
            int age = GetNumber();

            double ticketPrice = CalculateTicketPrice(age);
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }

        static int GetNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number) && number > 0)
                    return number;
                Console.Write("Invalid input. Please enter a valid age: ");
            }
        }

        static double CalculateTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
                return 7.0;
            else
                return 10.0;
        }
    }
}