namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3, 4, 5 };
            var linkedList = new LinkedList<string>();
            var words = new SortedDictionary<int, string>() { { 1, "one" }, { 2, "two" }, { 3, "three" } };
            var stack = new Stack<string>();
            var queue = new Queue<string>();
            var charSet = new SortedSet<char>() { 'a', 'b', 'd', 'c' };

            intList.Add(4);
            intList.AddRange([1, 2, 3]);
            intList.Add(5);
            intList.Insert(0, 5);
            intList.RemoveAt(0);
            intList[0] = 3;
            intList[1] = 4;

            intList.Sort();
            intList.Reverse();

            foreach (int el in intList)
            {
                Console.WriteLine(el);
            }
            intList.ForEach(el => Console.WriteLine(el));
            intList.ForEach(Console.WriteLine);

            /*
             * Linked List
             */

            var item1 = linkedList.AddFirst("Coding");
            var item2 = linkedList.AddAfter(item1, "Factory");
            linkedList.AddLast("AUEB");

            linkedList.First!.Next!.Next!.Value = "Athens Uni of Econ and Business";

            foreach (var el in linkedList)
            {
                Console.WriteLine(el);
            }

            linkedList.ToList().ForEach(x => Console.WriteLine(x));
            linkedList.ToList().ForEach(Console.WriteLine);

            // Dictionaries
            words.Add(1, "Athens");
            words[2] = "Uni";

            words.Remove(1);
            if (words.ContainsKey(4))
            {
                Console.WriteLine("Contains 4.");
            } else
            {
                words[4] = "Business";
            }

            foreach (var keyVal in words)
            {
                Console.WriteLine($"{keyVal.Key} -> {keyVal.Value}");
            }

            words.ToList().ForEach(x => Console.WriteLine($"{x.Key} -> {x.Value}"));

            /*
             * Sets
             */

            charSet.Add('x');
            charSet.Remove('a');

            //charSet.UnionWith(charSet2);

            foreach (var ch in charSet)
            {
                Console.WriteLine(ch + " ");
            }

            /*
             * Stack: push and pop
             */

            stack.Push("Hello");
            stack.Push("World");
            string popped = stack.Pop();
            Console.WriteLine($"Popped: {popped}");

            foreach (var el in stack)
            {
                Console.WriteLine(el);
            }

            /*
             * Queue: enqueue and dequeue
             */
            queue.Enqueue("car1");
            queue.Enqueue("car2");
            queue.Enqueue("car3");
            string car1 = queue.Dequeue(); // car1

            foreach (var car in queue)
            {
                Console.WriteLine(car);
            }
        }
    }
}
