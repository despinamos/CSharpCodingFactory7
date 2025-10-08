namespace ArraysOneDimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2]; // new
            arr[0] = 1;
            arr[1] = 2;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int[] arr2 = { 1, 2, 3 }; // unsized initialization

            foreach (int el in arr2)
            {
                Console.WriteLine(el);
            }

            int[] arr3 = new int[] {1, 2, 3, 4 }; // array initializer

            int[] arr4 = [1, 2, 3, 4]; // .NET 8, Collection init 

            int[] nonSymmetricArray = { 1, 2, 3, 4, 5 };
            int[] symmetricArray = { 1, 2, 3, 2, 1 };

            Console.WriteLine(IsSymmetric(nonSymmetricArray)); // False
            Console.WriteLine(IsSymmetric(symmetricArray)); // True

            Console.WriteLine(IsSymmetric2(nonSymmetricArray));
            Console.WriteLine(IsSymmetric2(symmetricArray));
        }

        public static bool IsSymmetric(int[] arr)
        {
            bool symmetric = true;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    symmetric = false;
                    break;
                }
            }
            return symmetric;
        }

        public static bool IsSymmetric2(int[] arr)
        {
            bool symmetric = true;
            
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                if (arr[i] != arr[j])
                {
                    symmetric = false;
                }
            }
            return symmetric;
        }
    }
}
