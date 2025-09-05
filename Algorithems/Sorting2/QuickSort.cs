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

            return i + 1;
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return;
            int n = arr.Length;
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, right.Length);

            Console.WriteLine($"Left array:{string.Join(",", left)}");
            Console.WriteLine($"Left array:{string.Join(",", right)}");
            MergeSort(left);
            MergeSort(right);

            var result = Merge(arr, left, right);

            Console.WriteLine($"MergeSort:{string.Join(",", result)}");
        }

        private static int[] Merge(int[] result, int[] left, int[] right)
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            int n1 = left.Length;
            int n2 = right.Length;

            while (p1 < n1 && p2 < n2)
            {
                if (left[p1] < right[p2])
                {
                    result[p3] = left[p1];
                    p1++;
                }
                else
                {
                    result[p3] = right[p2];
                    p2++;
                }
                p3++;
            }

            while (p1 < n1)
            {
                result[p3] = left[p1];
                p1++;
                p3++;
            }
            while (p2 < n2)
            {
                result[p3] = right[p2];
                p2++;
                p3++;
            }

            return result;

        }
    }

    public class HeapMax
    {

        public static void Run(int[] arr)
        {
            // Heapify(arr, 0, arr.Length);
            HeapifyMax(arr);
            SortHeapify(arr);
        }

        private static void SortHeapify(int[] arr)
        {
            int n = arr.Length;
            int largest = arr[0];
            for (int i = n-1; i >=1; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                Heapify(arr,0,i);
            }
        }

        private static void HeapifyMax(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, i, n);
            }
        }

        private static void Heapify(int[] arr, int i, int n)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int largest = i;

            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, largest, n);
            }

            Console.WriteLine($"HeapyMax: {string.Join(",", arr)}");

        }
    }

    
}