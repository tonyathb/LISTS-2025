using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObratnChis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            long sum = 0;
            List<int> revNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int revNum=GenerateReverseNumber(numbers[i]);
                //Console.Write($"{revNum} + ");
                revNumbers.Add(revNum);
                sum = sum + revNum;
            }
            Console.WriteLine($"{string.Join(" + " ,revNumbers)} = {sum}");
            Console.WriteLine("--------------------------------------------");

            //broy na четните числа
            int countEven = CountEvenNumbers(numbers);
            //njnbb
            Console.WriteLine($"Count eventNums= {countEven}");
        }

        private static int CountEvenNumbers(List<int> nmbrs)
        {
            int result = 0;
            for (int i = 0; i < nmbrs.Count; i++)
            {
                if (nmbrs[i] % 2 == 0)
                {
                    result++;
                }
            }
            return result;
        }

        static int GenerateReverseNumber(int num)
        {
            int result = 0;
            while(num != 0)
            {
                int digit = num % 10;
                result = result * 10 + digit;
                num /= 10;
            }
            return result;
        }
    }
}
