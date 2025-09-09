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

            Console.WriteLine($"Bubble Sort: {string.Join(",", arr)}");
        }

        public static void Heap(int[] arr)
        {
            Console.WriteLine($"Before Heap: {string.Join(", ", arr)}");
            Heapify(arr, 0, arr.Length);
            Console.WriteLine($"After Heap: {string.Join(", ", arr)}");
        }

        private static void Heapify(int[] arr, int i, int n)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int largest = i;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, largest,n);
            }
        }

        


    }
}