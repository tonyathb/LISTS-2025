

using System;
using System.Collections.Generic;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaraation
            List<int> numbers = new List<int>();
            //input ELEMENTS
            string otgovor = "";//null
            do
            {
                Console.Write("Daj element int");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
                Console.Write("Oste lementi? Y/N  = ");
                otgovor = Console.ReadLine();
            } while (otgovor == "Y");





            //print
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
