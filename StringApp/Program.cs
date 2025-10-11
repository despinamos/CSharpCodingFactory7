namespace StringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "AUEB";
            string s2 = "AUEB"; // String Interning
            string passwrd = "pass";
            string passwrd2 = "PASS";

            // Equality
            Console.WriteLine($"{s1.Equals(s2)}");
            Console.WriteLine($"{s1 == s2}");
            Console.WriteLine($"{ReferenceEquals(s1, s2)}");

            // < <= > >=
            Console.WriteLine($"{String.Compare(s1, s2)}");
            Console.WriteLine($"{s1.CompareTo(s2)}");

            // concat
            String hello = "Hello";
            String world = "World";
            string helloWorld = String.Concat(hello, " ", world);
            string helloWorld2 = hello + " " + world;
            Console.WriteLine(helloWorld);
            Console.WriteLine(helloWorld2);

            // ToUpper(), ToLower()

            bool areEqual = passwrd.ToUpper().Equals(passwrd2.ToUpper());

            // IndexOf
            string str = "C# Programming Language";
            int index = str.IndexOf("#"); // 1
            int index2 = str.IndexOf("a", 15);
            string subStr = str.Substring(3); // "Programming Language"
            string subStr2 = str.Substring(3, 11); // "Programming"

            // Trim()
            string s = "      Something    ";
            string trimmed = s.Trim(); // "Something"
            char[] chars = new char[] { ' ', '$', '#' };
            string trimmed2 = s.Trim(chars);
            Console.WriteLine(trimmed);
            Console.WriteLine(trimmed2);
        }

        public static bool IsPallindrome(string s)
        {
            bool pallindrome = true;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    pallindrome = false;
                break;
            }
            return pallindrome;
        }
    }
}
