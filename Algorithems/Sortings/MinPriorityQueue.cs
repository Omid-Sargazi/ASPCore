using System.Data;

namespace Algorithems.Sortings
{
    public class MinPriorityQueue
    {
        private List<int> heap = new List<int>();
        public MinPriorityQueue() { }

        public MinPriorityQueue(IEnumerable<int> items)
        {
            heap = new List<int>(items);
            //BuildHeap();
        }

        public int Count => heap.Count;
        public bool IsEmpty => heap.Count == 0;

        public void Insert(int value)
        {
            heap.Add(value);
            SiftUp(heap.Count -1);
        }

        public int PeekMin()
        {
            if (IsEmpty) throw new InvalidOperationException("Priorityqueue is empty");
            return heap[0];
        }

        public int ExtractMin()
        {
            if (IsEmpty) throw new InvalidOperationException("Priorityqueue is empty");

            int min = heap[0];
            int lastIndex = heap.Count - 1;

            heap[0] = heap[lastIndex];
            heap.RemoveAt(lastIndex);

            if (!IsEmpty) return 0;//SiftDown(0);
            return min;
        }

        public void SiftDown(int index)
        {
            int current = index;
            int n = heap.Count;

            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int smallest = current;

                if (left < n && heap[smallest] > heap[left])
                    smallest = left;
                if (right < n && heap[smallest] > heap[right])
                    smallest = right;

                if (smallest == current) break;

                Swap(current, smallest);
                current = smallest;
            }
        }


        public void BuildHeap()
        {
            int n = heap.Count;
            for (int i = n / 2 - 1; n >= 0; i--)
            {
                SiftDown(i);
            }
        }

        public override string ToString() => string.Join(", ", heap);

        private void SiftUp(int index)
        {
            int current = index;
            while (current > 0)
            {
                int parrent = (current - 1) / 2;
                if (heap[current] < heap[parrent])
                {
                    Swap(current, parrent);
                    current = parrent;
                }
                else
                {
                    break;
                }

            }
        }


        private void Swap(int i, int j)
        {
            (heap[i], heap[j]) = (heap[j], heap[i]);
        }
    }
}