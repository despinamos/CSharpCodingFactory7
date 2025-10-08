namespace RightTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPSILON = 0.000005;
            bool isRight = false;

            Console.WriteLine("Please give the lengths of the three sides of the triangle (a, b, c): ");
           
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Format error. Must be double.");
            }

            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Format error. Must be double.");
            }

            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Format error. Must be double.");
            }

            Console.WriteLine($"The lengths of the three sides of the triangle are: a={a}, b={b}, c={c}");

            isRight = Math.Abs(a * a - b * b - c * c) < EPSILON;
            Console.WriteLine("The triangle is {0} right", (isRight) ? " " : "not");
        }
    }
}
