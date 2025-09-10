using System.Text.RegularExpressions;

namespace Algorithems.Hashing
{
    public class HashTableChaining
    {
        private List<int>[] _buckets;
        private int _m;//Number of buckets;
        private int _n;//Number of elements;

        public HashTableChaining(int m)
        {
            _m = m;
            _buckets = new List<int>[m];
            for (int i = 0; i < m; i++)
            {
                _buckets[i] = new List<int>();
            }
            _n = 0;
        }


        private int Hash(int key)
        {
            int h = key % _m;
            if (h < 0) h += _m;
            return h;
        }

        public void Insert(int key)
        {
            int index = Hash(key);
            if (_buckets[index].Contains(key))
            {
                _buckets[index].Add(key);
                _n++;
            }
        }

        public bool Search(int key)
        {
            int index = Hash(key);
            return _buckets[index].Contains(key);
        }

        public bool Remove(int key)
        {
            int index = Hash(key);
            bool removed = _buckets[index].Remove(key);
            if (removed) _n--;

            return removed;
        }

        public void PrintTable()
        {
            for (int i = 0; i < _m; i++)
            {
                Console.WriteLine($"idx {i}: [{string.Join(" -> ", _buckets[i])}]");
            }
        }
    }
}