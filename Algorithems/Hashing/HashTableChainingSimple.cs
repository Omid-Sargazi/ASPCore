using System.Reflection.Metadata;

namespace Algorithems.Hashing
{
    public class HashTableChainingSimple
    {
        private List<int>[] buckets;
        private int m;

        public HashTableChainingSimple(int m)
        {
            this.m = m;
            buckets = new List<int>[m];
            for (int i = 0; i < m; i++) buckets[i] = new List<int>();
        }

        private int Hash(int key) => Math.Abs(key % m);

        public void Insert(int key)
        {
            int idx = Hash(key);
            buckets[idx].Add(key);
        }

        public bool Search(int key)
        {
            int idx = Hash(key);
            return buckets[idx].Contains(key);
        }

        public bool Remove(int key)
        {
            int idx = Hash(key);
            return buckets[idx].Remove(key);
        }

        public void PrintTable()
        {
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"idx {i}: [{string.Join(" -> ", buckets[i])}]");
            }
        }


        public static void HashTableChainingSimpleRun()
        {
            var ht = new HashTableChainingSimple(5);
            int[] keys = { 3, 8, 15, 11, 26 };

            foreach (var k in keys)
            {
                Console.WriteLine($"Insert {k}:");
                ht.Insert(k);
                ht.PrintTable();
                Console.WriteLine();
            }

            Console.WriteLine($"Search 26: " + (ht.Search(26) ? "Found" : "Not Found"));
            Console.WriteLine($"Search 99: " + (ht.Search(99) ? "Found" : "Not Found"));

            Console.WriteLine("\nRemove 8:");
            ht.Remove(8);
            ht.PrintTable();
        }
    }


}