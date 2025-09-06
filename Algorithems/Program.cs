// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using Algorithems.Sorting2;
using Algorithems.Sortings;

public class Program
{
    public static async Task Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        int[] arr1 = new int[] { 74, 47, 98, -98, -85, 2, 11, 3 };
        int[] arr2 = new int[] { 1, 2, 3 };

        // Sorting.Bubble(arr1);
        // Sorting.SelectionSort(arr1);
        // Sorting.InsertionSort(arr1);
        // Sorting2.QuickSort(arr1,0,arr1.Length-1);
        // Sorting2.MergeSort(arr1);
        // HeapMax.Run(arr1);

        Span<int> slice = arr1.AsSpan(1, 3);
        foreach (var item in slice)
        {
            Console.WriteLine($"slice: {item}");
        }

        slice[0] = 99;
        Console.WriteLine(arr1[1]);

        Memory<int> memory = arr1.AsMemory(1, 3);
        await PrintAsync(memory);
        var Stored = memory;

        // SpanAndMemory.RunSpan();
        await SpanAndMemory.RunMemory();

    }

    public static async Task PrintAsync(Memory<int> mem)
    {
        await Task.Delay(1000);
        foreach (var n in mem.Span)
        {
            Console.WriteLine(n);
        }
    }


}