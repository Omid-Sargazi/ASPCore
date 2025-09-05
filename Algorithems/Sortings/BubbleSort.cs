namespace Algorithems.Sortings
{
    public class Sorting
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

            Console.WriteLine($"{string.Join(", ", arr)}");
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                if (i != minIndex)
                    (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
            Console.WriteLine($"{string.Join(", ", arr)}");

        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                (arr[j + 1], current) = (current, arr[j + 1]);
            }
            Console.WriteLine($"{string.Join(", ", arr)}");

        }

        public static void QuickSort(int[] arr, int lo, int hi)
        {
            if (lo>=hi) return;
            // int n = arr.Length - 1;
            int pi = Partition(arr, lo, hi);
            QuickSort(arr, lo, pi - 1);
            QuickSort(arr, pi + 1, hi);

            Console.WriteLine($"{string.Join(", ", arr)}");
        }

        private static int Partition(int[] arr, int lo, int hi)
        {
            int pivot = arr[hi];
            int i = lo - 1;
            for (int j = lo; j < hi; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }

            }
                (arr[i + 1], arr[hi]) = (arr[hi], arr[i + 1]);

            return i + 1;
        }
    }
}