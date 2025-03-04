using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InsertRemoveInArray
{
    class Program
    {
        static string[] RemoveAt(string[] input, int index)
        {
            if (index < 0 || index > input.Length - 1)
            {
                return input;
            }
            string[] output = new string[input.Length - 1];
            for (int i = 0; i < index; i++)
            {
                output[i] = input[i];
            }
            for (int i = index; i < input.Length - 1; i++)
            {
                output[i] = input[i + 1];
            }
            return output;
        }
        static string[] Insert(string[] arr, int index, string newElement)
        {
            string[] res = new string[arr.Length + 1];
            if (index < 0 || index > arr.Length)
            {
                return arr;
            }

            res = new string[arr.Length + 1];
            for (int i = 0; i < index; i++)
            {
                res[i] = arr[i];
            }
            res[index] = newElement;
            for (int i = index + 1; i < arr.Length; i++)
            {
                res[i] = arr[i - 1];
            }
            return res;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0].ToUpper() != "END")
            {
                string[] output=input;
                switch (command[0])
                {
                    case "Insert":
                        {
                            int ind = int.Parse(command[1]);
                            string element = command[2];
                            output = Insert(input, ind, element);
                            break;
                        }
                    case "RemoveAt":
                        {
                            int nom = int.Parse(command[1]);
                            output = RemoveAt(input, nom);
                            break;
                        }
                }

                //////if (command[0] == "Insert")
                //////{
                //////    int ind = int.Parse(command[1]);
                //////    string element = command[2];
                //////    output = Insert(input, ind, element);
                //////    //if (ind < 0 || ind > input.Length)
                //////    //{
                //////    //    continue;
                //////    //}

                //////    //output = new string[input.Length + 1];
                //////    //for (int i = 0; i < ind; i++)
                //////    //{
                //////    //    output[i] = input[i];
                //////    //}
                //////    //output[ind] = element;
                //////    //for (int i = ind + 1; i < output.Length; i++)
                //////    //{
                //////    //    output[i] = input[i - 1];
                //////    //}
                //////    Console.WriteLine(string.Join(", ", output));
                //////    Console.WriteLine("----------------Input new command------------------");
                //////    command = Console.ReadLine().Split().ToArray();
                //////    input = output;
                //////}

                //////if (command[0] == "RemoveAt")
                //////{

                //////    int nom = int.Parse(command[1]);
                //////    output = RemoveAt(input, nom);

                //////    //output = new string[input.Length - 1];
                //////    //for (int i = 0; i < ind; i++)
                //////    //{
                //////    //    output[i] = input[i];
                //////    //}
                //////    //for (int i = ind; i < input.Length - 1; i++)
                //////    //{
                //////    //    output[i] = input[i + 1];
                //////    //}
                //////    Console.WriteLine(string.Join(", ", output));
                //////    Console.WriteLine("----------------Input new command------------------");
                //////    command = Console.ReadLine().Split().ToArray();
                //////    input = output;
                //////    continue;
                //////}

                Console.WriteLine(string.Join(", ", output));
                Console.WriteLine("----------------Input new command------------------");
                command = Console.ReadLine().Split().ToArray();
                input = output;

            }
        }
    }
}
