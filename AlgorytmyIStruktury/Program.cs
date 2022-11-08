using System;

namespace AlgorytmyIStruktury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //int[] arr = { 12, 11, 13, 5, 6 };
            //InsertionSort ob = new InsertionSort();
            //ob.sort(arr);
            //ob.printArray(arr);
            //////////////////////////////////////////////////////////////////////////////////////

            //
            //int[] arr2 = { 12, 11, 13, 5, 6, 7 };
            //Console.WriteLine("Given Array");
            //MergeSort ms = new MergeSort();
            //ms.printArray(arr2);
            //ms.sort(arr2, 0, arr2.Length - 1);
            //Console.WriteLine("\nSorted array");
            //ms.printArray(arr2);
            //////////////////////////////////////////////////////////////////////////////////////

            //
            //int[] arr3 = { 10, 7, 8, 9, 1, 5 };
            //int n = arr3.Length;
            //QuickSortClassic qsc = new QuickSortClassic();
            //qsc.quickSort(arr3, 0, n - 1);
            //Console.WriteLine("Sorted array: ");
            //qsc.printArray(arr3, n);
            //////////////////////////////////////////////////////////////////////////////////////

            int[] a = Generators.GenerateRandom(size: 10, minVal: 0, maxVal: 20);
            foreach (int entry in a)
                Console.Write(entry + " ");

            Console.WriteLine();

            int[] a2 = Generators.GenerateSorted(size: 10, minVal: 0, maxVal: 20);
            foreach (int entry in a2)
                Console.Write(entry + " ");

            Console.WriteLine();

            int[] a3 = Generators.GenerateReversed(size: 10, minVal: 0, maxVal: 20);
            foreach (int entry in a3)
                Console.Write(entry + " ");
        }
    }
}
