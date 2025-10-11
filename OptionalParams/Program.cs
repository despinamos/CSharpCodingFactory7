namespace OptionalParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = getDateTime();
            Console.WriteLine($"{dateTime:D}");

            DateTime dateTime2 = getDateTime();
            Console.WriteLine($"{dateTime2:F}");
        }

        public static DateTime getDateTime(int year=2024, int month=11, int day=1, int min=0, int seconds=0, int milli=0)
        {
            return new DateTime(year, month, day, min, seconds, milli, DateTimeKind.Utc);
        }
    }
}
