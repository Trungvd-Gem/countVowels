using System;
using System.Text;

namespace sortedArray
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arr = { 1, 5, 3, 9, 8, 11, 15, 0 };
            int i, j, max, leng;

            leng = arr.Length;

            for (i = 0; i < leng - 1; i++)
            {
                for (j = i + 1; j < leng; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        max = arr[i];
                        arr[i] = arr[j];
                        arr[j] = max;
                    }
                }
            }

            // Sort Arrat
            Console.WriteLine("Array after sort: ");
            for (i = 0; i < leng; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            // Max and Min Number
            Console.Write("\n\n");
            Console.Write("Max Number of array: " + arr[leng - 1]);
            Console.Write("\n\n");
            Console.Write("Min Number of array: " + arr[0]);

            Console.ReadLine();
        }
    }
}

