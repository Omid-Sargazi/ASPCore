namespace Algorithems.Sorting2
{
    public class Sorting2
    {
        public static void QuickSort(int[] arr, int lo, int hi)
        {
            if (lo >= hi) return;
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
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                }
            }
            (arr[i + 1], arr[hi]) = (arr[hi], arr[i + 1]);

            return i+1;
        }
    }
}