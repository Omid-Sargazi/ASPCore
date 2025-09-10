// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using Algorithems.Sorting2;
using Algorithems.Sorting3;
using Algorithems.Sortings;
using Algorithems.Sorting3;
using Algorithems.Hashing;

public class Program
{
    public static async Task Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        int[] arr1 = new int[] { 74, 47, 98, -98, -85, 2, 11 };
        int[] arr2 = new int[] { 1, 2, 3 };
        int[] keys = { 10, 22, 31, 4, 15, 28 };



        // Sorts.Bubble(arr1);

        // var ht = new HashTableChaining(7);
        // foreach (var k in keys) ht.Insert(k);
        // ht.PrintTable();
        // Console.WriteLine(ht.Search(31));

        HashTableChainingSimple.HashTableChainingSimpleRun();
    }

    public static async Task PrintAsync(Memory<int> mem)
    {
        await Task.Delay(1000);
        foreach (var n in mem.Span)
        {
            // Console.WriteLine(n);
        }
    }


}