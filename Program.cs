using System;
using System.IO;
using System.Diagnostics;

namespace MySelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] BigArr = new int[10000];
            Random RanGen = new Random();
            for (int i = 0; i < BigArr.Length; i++)
            {
                BigArr[i] = RanGen.Next(0, 100000);
            }
            Console.WriteLine("Press any key to view the unsorted array.");
            Console.ReadKey();
            Console.WriteLine("\n");
            for (int i = 0; i < BigArr.Length; i++)
            {
                if (i < BigArr.Length - 1)
                {
                    Console.Write(BigArr[i] + ", ");
                }
                else
                {
                    Console.Write(BigArr[i]);
                }
            }
            Stopwatch timer = Stopwatch.StartNew();
            SelSort(BigArr, BigArr.Length);
            timer.Stop();
            long algTime = timer.ElapsedMilliseconds;
            Console.WriteLine("\n\nBubble sort algorithm took " + algTime + " milliseconds.\n");
            Console.WriteLine("Press any key to view the sorted array.\n");
            Console.ReadKey();
            for (int i = 0; i < BigArr.Length; i++)
            {
                if (i < BigArr.Length - 1)
                {
                    Console.Write(BigArr[i] + ", ");
                }
                else
                {
                    Console.Write(BigArr[i]);
                }
            }
            Console.WriteLine("\n\nPress any key to end the program.");
            Console.ReadKey();
        } // end of method Main
        static int[] SelSort(int[] Arr, int n)
        {
            int minIdx;
            int hold;
            for (int i = 0; i < n - 1; i++)
            {
                minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Arr[j] < Arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                // low cardinality data sets sort faster with an if statement, high cardinality data sets sort faster without
                // if (Arr[i] != Arr[minIdx])
                hold = Arr[minIdx];
                Arr[minIdx] = Arr[i];
                Arr[i] = hold;
            }
            return Arr;
        } // end of method SelSort
    } // end of class Program
} // end of namespace MySelectionSort
