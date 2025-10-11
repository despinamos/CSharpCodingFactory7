namespace ParamsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            result = Add(1, 5, 3, 7);
            Console.WriteLine(result);
            result = Add(1, 5);
            Console.WriteLine(result);
        }

        /// <summary>
        /// A type of overloading method that accepts a variable number of arguments.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
