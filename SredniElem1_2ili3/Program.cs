using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SredniElem1_2ili3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nums.Length;
            if (n == 1) Console.WriteLine(nums[0]);
            int midIndex = n / 2;
            if (n % 2 == 0)
            {
                Console.WriteLine($" {nums[midIndex-1]}, {nums[midIndex]}");
            }
            else
            {
                Console.WriteLine($"{nums[midIndex-1]}, {nums[midIndex]}, {nums[midIndex+1]}");
            }



            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"{nums[i]}, ");
            //}

        }
    }
}
