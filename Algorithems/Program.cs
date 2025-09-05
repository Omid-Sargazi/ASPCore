// See https://aka.ms/new-console-template for more information
using Algorithems.Sorting2;
using Algorithems.Sortings;

Console.WriteLine("Hello, World!");
int[] arr1 = new int[] { 74, 47, 98, -98, -85, 2, 11, 3 };
int[] arr2= new int[] { 1, 2, 3 };

// Sorting.Bubble(arr1);
// Sorting.SelectionSort(arr1);
// Sorting.InsertionSort(arr1);
// Sorting2.QuickSort(arr1,0,arr1.Length-1);
Sorting2.MergeSort(arr1);