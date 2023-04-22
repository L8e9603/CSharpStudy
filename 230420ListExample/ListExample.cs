using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ELEMENTS_COUNT = 10;

            List<int> list = new List<int>();
            for (int i = 0; i < ELEMENTS_COUNT; i++)
            {
                list.Add(i);
            }

            Console.WriteLine($"[ {string.Join(", ", list)} ]");

            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine($"[ {string.Join(", ", list2)} ]");

            Console.WriteLine($"First element: {list[0]}");
            Console.WriteLine($"Last element: {list[list.Count - 1]}");
        }
    }
}