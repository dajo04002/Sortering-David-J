using System;
using System.Diagnostics;
using System.Linq;


namespace Selectionsort_Complete
{
    public class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static public void Selectionsort(int[] arr)
        {
            int smallest;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                Swap(ref arr[smallest], ref arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int length = 64000; //Enter length of randomised list
            int[] arr = new int[length];

            Random rnd = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
            }
            

            Console.WriteLine("Unsorted");
            
            foreach(int e in arr)
            {
                Console.WriteLine(e);
            }

            Stopwatch stopwatch = new();

            stopwatch.Start();
            Selectionsort(arr);
            stopwatch.Stop();

            Console.WriteLine("Sorted");
            
            foreach(int e in arr)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Elements: " + length);
            Console.WriteLine(" Elapsed Time for Selectionsort: {0} ms", stopwatch.Elapsed.Milliseconds);
        }
    }
}
