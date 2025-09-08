// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using Algorithems.Sorting2;
using Algorithems.Sorting3;
using Algorithems.Sortings;
using Algorithems.Sorting3;

public class Program
{
    public static async Task Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        int[] arr1 = new int[] { 74, 47, 98, -98, -85, 2, 11, 3 };
        int[] arr2 = new int[] { 1, 2, 3 };

        

        Sorts.Bubble(arr1);
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