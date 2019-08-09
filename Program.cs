
//Maximum difference between two elements such that larger element appears after the smaller number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatesDiff
{
    class Program
    {
        static int maxDiff(int[] arr, int arr_size)
        {
            int max_diff = arr[1] - arr[0];
            int i, j;
            for (i = 0; i < arr_size; i++)
            {
                for (j = i + 1; j < arr_size; j++)
                {
                    if (arr[j] - arr[i] > max_diff)
                        max_diff = arr[j] - arr[i];
                }
            }
            return max_diff;
        } 
  
        static void Main(string[] args)
        {
            

                int[] arr = { 1, 2, 90, 10, 110 };
                Console.Write("Maximum differnce is " +
                                        maxDiff(arr, 5));
                Console.ReadKey();
            
        }
    }
}
