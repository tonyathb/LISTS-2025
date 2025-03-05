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
                if (result.Contains(arr[i])==false)
                {
                    result.Add(arr[i]);
                }
            }
            return result;
        }

        static void Repleace(List<string> list, int index, string newValue)
        {
            if(index<0 || index > list.Count - 1)
            {
                Console.WriteLine("Nevaliden index");
                return;
            }
            list[index] = newValue;
        }

        //static void Print(List)

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<string> output = new List<string>(input);
            //br. commmands
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "Reverse": output = Reverse(output); break;
                    case "Distinct": output = Distinct(output);break;
                    case "Repleace":
                        {
                            int index = int.Parse(command[1]);
                            string element = command[2];
                            Repleace(output, index, element);
                            break;
                        }
                    case "Insert":
                        {
                            int index = int.Parse(command[1]);
                            string element = command[2];
                            output.Insert(index, element);
                            break;
                        }
                }

                Console.WriteLine(string.Join(", ",output));
            }
        }
    }
}
