using PointApp.Model;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1);
            Point p2 = new Point2D(1, 2);
            Point p3 = new Point3D(1, 2, 3);

            Point p4 = new Point3D()
            {
                X = 10,
                Y = 20,
                Z = 30
            };

            p1.X = 20;
            // p2.Y = 20; // Error because it is not a property of Point
            ((Point2D)p2).Y = 30;

            p4.Move10(); // Move X, Y, Z by 10
            p1.Move10(); // Move X by 10

            Console.WriteLine(p1); // {20}
            Console.WriteLine(p2); // {1} {30}
            Console.WriteLine(p3); // {1} {2} {3}
            Console.WriteLine(p4); // {20} {30} {40}
        }
    }
}
