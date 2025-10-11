namespace GradesApp
{
    /// <summary>
    /// Gets as input total marks and courses count
    /// and calculates average and grade (A+, A, B, etc.)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double average;

            Console.WriteLine("Please enter total marks and courses count");

            if (!int.TryParse(Console.ReadLine(), out int totalMarks))
            {
                Console.WriteLine("Error. Invalid input.");
                return;
            }

            if (totalMarks < 0)
            {
                Console.WriteLine("Total marks must not be a negative number.");
                Environment.Exit(1);
            }

            if (!int.TryParse(Console.ReadLine(), out int coursesCount))
            {
                Console.WriteLine("Error. Invalid input.");
                return;
            }

            if (coursesCount < 0)
            {
                Console.WriteLine("Courses count must not be a negative number.");
                Environment.Exit(1);
            }

            average = totalMarks / (double) coursesCount;

            if (average > 10)
            {
                Console.WriteLine("Average must not be greater than 10");
            }

            switch (average)
            {
                case >= 9.0:
                    Console.WriteLine($"A+: {average}");
                    break;
                case >= 8.0:
                    Console.WriteLine($"A: {average}");
                    break;
                case >= 7.0:
                    Console.WriteLine($"B: {average}");
                    break;
                case >= 6.0:
                    Console.WriteLine($"C: {average}");
                    break;
                case >= 5.0:
                    Console.WriteLine($"D: {average}");
                    break;
                default:
                    Console.WriteLine($"Failure: {average}");
                    break;
            }
        }
    }
}
