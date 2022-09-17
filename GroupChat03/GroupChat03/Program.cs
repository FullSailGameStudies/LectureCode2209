namespace GroupChat03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> unsorted = Load();
            List<string> sorted = BubbleSort(unsorted, out int bubbleCount);
            for (int i = 0; i < unsorted.Count; i++)
            {
                Console.WriteLine($"{unsorted[i],-50} {sorted[i]}");
            }
            Console.WriteLine($"Bubble sort loops: {bubbleCount}");
            Console.ReadKey();
        }

        private static List<string> BubbleSort(List<string> unsorted, out int bubbleCount)
        {
            bubbleCount = 0;
            List<string> sorted = unsorted.ToList();
            int n = unsorted.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= n-1; i++)
                {
                    bubbleCount++;
                    if (sorted[i - 1].CompareTo(sorted[i]) > 0)
                    {
                        (sorted[i - 1], sorted[i]) = (sorted[i], sorted[i - 1]);//tuple
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
            return sorted;
        }

        static List<string> Load()
        {
            return File.ReadAllText("inputFile.csv").Split(',').ToList();
        }

    }
}