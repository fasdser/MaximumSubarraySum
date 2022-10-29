using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubarraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.ReadKey();
        }

        public static int MaxSequence(int[] arr)
        {
            int maxSum = 0;
            int partialSum = 0;
            int negative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negative++;
                }
            }

            if (negative == arr.Length)
            {
                return 0;
            }

            foreach (int item in arr)
            {
                partialSum += item;
                maxSum = Math.Max(maxSum, partialSum);
                if (partialSum < 0)
                {
                    partialSum = 0;
                }
            }


            return maxSum;
        }

        public static int MaxSequence1(int[] arr)
        {
            int max = 0, res = 0, sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                max = sum > max ? max : sum;
                res = res > sum - max ? res : sum - max;
            }
            return res;
        }
    }
}
