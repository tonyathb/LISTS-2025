using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comands
{
    class Program
    {
        static List<string> Reverse(List<string> arr)
        {
            //list otzad napred
            List<string> result = new List<string>(); //null
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                result.Add(arr[i]);
            }
            return result;
        }

        static List<string> Distinct(List<string> arr)
        {
            //list otzad napred
            List<string> result = new List<string>(); //null
            for (int i = 0; i < arr.Count; i++)
            {
                if (!result.Contains(arr[i]))
                {
                    result.Add(arr[i]);
                }
            }
            return result;
        }

        static void Repleace(List<string> arr, int index, string newElement)
        {
            if (index < arr.Count)
            {
                arr[index] = newElement;
            }
        }

        //static void Print(List)

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<string> output = new List<string>(input);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "Distinct": output = Distinct(output); break;
                    case "Add":
                        {
                            int ind = int.Parse(command[1]);
                            string value = command[2];
                            output.Insert(ind, value);
                            break;
                        }
                    case "Reverse": output = Reverse(output); break;
                    case "Repleace":
                        {
                            int ind = int.Parse(command[1]);
                            string value = command[2];
                            Repleace(output, ind, value); 
                            break;
                        }
                    case "Remove":
                        {
                            int index = int.Parse(input[1]);
                            output.RemoveAt(index);
                            break;
                        } 
                }
                Console.WriteLine(string.Join(" ", output));
            }

        }
    }
}
