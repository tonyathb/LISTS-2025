using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisINTNumbers
{
    class Program
    {
        static void Main ()
        {
            List<int> lstNumbers = new List<int>();//declarirane na list
                       
            lstNumbers = Console.ReadLine() //chete do ENTER
                         .Split(' ') //razdelq po ' ' ==> string[]
                         .Select(int.Parse) //maha "4" => 4
                         .ToList(); // sglobyava do list<int>

            List<int> negativeNumbers = new List<int>();
            for (int i = 0; i < lstNumbers.Count; i++)
            {
                if (lstNumbers[i] < 0)
                {
                    negativeNumbers.Add(lstNumbers[i]);
                }
            }

            Console.WriteLine(string.Join(", ", negativeNumbers)); //pechat na edin s , //


            for (int i = lstNumbers.Count-1; i>=0 ; i--)
            {
                Console.WriteLine($"list[{i}] = {lstNumbers[i]}");   
            }

        }
    }
}
