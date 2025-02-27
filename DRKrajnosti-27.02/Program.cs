using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRKrajnosti_27._02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();//new List<int>();
                


             List<int> repetElements = new List<int>();
            int bestStart;
            int bestLength = 1;
            int count = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
               
                if (numbers[i] == numbers[i + 1])
                {
                    bestStart = i;
                    count++;

                    repetElements.Add(numbers[i]);
                }
                else
                {
                    if (count > bestLength)
                    {
                        bestLength = count;
                    }
                    else
                    {
                        repetElements.Clear();
                    }
                    count = 1;
                }
            }
            if (repetElements.Count >0)
            {
                Console.WriteLine(string.Join(" ",repetElements));
            }
        }
    }
}
