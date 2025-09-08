namespace Algorithems.Sorting3
{
    public class Sorts
    {
        public static void Bubble(int[] arr)
        {
            for (int start = arr.Length - 1; start >= 0; start--)
            {
                bool swapped = false;
                for (int j = 0; j < start; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }

            Console.WriteLine($"Bubble Sort: {string.Join(",",arr)}");
        }
    }
}