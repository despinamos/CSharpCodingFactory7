namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Swap(a, b);
            Console.WriteLine($"Without ref: a={a}, b={b}");
            SwapRef(ref a, ref b);
            Console.WriteLine($"With ref: a={a}, b={b}");

            string s = "Hello";
            changeStr(s);
            Console.WriteLine($"ChangeStr: {s}");
            changeStrRef(ref s);
            Console.WriteLine($"ChangeStr with ref: {s}");

            string? nullString = null;
            changeStrRefOut(out nullString);
            Console.WriteLine($"ChangeStr with out that works with null strings: {s}");

        }

        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void SwapRef(ref int a, ref int b)
        {
            //int temp = a;
            //a = b;
            //b = temp;
            (a, b) = (b, a); // Tuple deconstruction to swap values
        }

        public static void changeStr(string str)
        {
            str = "AUEB";
        }
        public static void changeStrRef(ref string str)
        {
            str = "AUEB";
        }
        public static void changeStrRefOut(out string str)
        {
            str = "AUEB";
        }
    }
}
