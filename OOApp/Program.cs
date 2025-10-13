using OOApp.Model;

namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher alice = new Teacher();
            Teacher bob = new(); // >= C#9.0
            var costas = new Teacher();

            // Object Initializer, needs default constructor and setters
            Teacher anna = new Teacher()
            {
                Id = 1,
                Firstname = "Anna",
                Lastname = "Smith"
            };

            Teacher andreas = new Teacher(1, "Andreas", "Androutsos", SchoolType.IEK);
        }
    }
}
