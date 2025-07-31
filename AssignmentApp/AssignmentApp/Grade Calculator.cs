namespace AssignmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Grade Calculator----");
            Console.Write("Enter a grade between 0 and 100: ");
            double grade = GetNumber();

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }

            string letterGrade = GetLetterGrade(grade);
            Console.WriteLine($"The letter grade is: {letterGrade}");
        }

        static double GetNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                    return number;
                Console.Write("Invalid input. Please enter a valid number: ");
            }
        }

        static string GetLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }
    }
}