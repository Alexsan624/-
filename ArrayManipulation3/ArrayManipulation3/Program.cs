using System;
using System.Linq;

namespace ArrayManipulation3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            while(true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                string[] command = line.Split();
                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string newWord = command[2];
                        arr[index] = newWord;
                        break;
                    case "Print":
                        {
                            foreach (var item in arr)
                            {
                                if (item.StartsWith(command[1]))
                                {
                                    Console.Write(item + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        }
                }
                Console.WriteLine(string.Join(", ", arr));
            }
        }
    }
}
