namespace ArraysTwoDim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int MAX = 6;
            const int MIN = 1;

            int[,] grid = new int[3, 4];
            int[,] grid2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < grid2.GetLength(0); i++)
            {
                for (int j = 0; j < grid2.GetLength(1); j++)
                {
                    Console.Write(grid2[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = random.Next(MAX - MIN + 1) + MIN;
                }
                Console.WriteLine();
            }

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[1] = new int[3];
            jagged[2] = new int[4];

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = random.Next(MAX - MIN + 1) + MIN;
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            foreach (int[] row in jagged)
            {
                foreach (int item in row)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
