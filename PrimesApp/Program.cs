namespace PrimesApp
{
    /// <summary>
    /// Calculates if a number is Prime.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
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
