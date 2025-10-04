namespace PrimesApp
{
    /// <summary>
    /// Calculates all prime numbers in a specific range (ex. from 1 to 20).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerRange, upperRange;

            Console.WriteLine("Please give the range: ");
            lowerRange = int.Parse(Console.ReadLine()!);
            upperRange = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Calculating all Prime numbers from {lowerRange} to {upperRange}");

            for (int i = lowerRange; i <= upperRange; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool isPrime(int n)
        {
            bool prime = true;

            for (int divider = 2; divider <= Math.Sqrt(n); divider++)
            {
                if (n % divider == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
    }
}
