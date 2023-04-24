using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program2
    {
        public void Main(string args)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(0, 10);
                list.Add(number);
            }

            Console.WriteLine($"[ {string.Join(", ", list)} ]");

            // 딕셔너리를 이용해 리스트의 중복된 요소 제거
            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();

            for (int i = 0; i < list.Count; i++)
            {
                if (dictionary.ContainsKey(list[i]))
                {
                    list.RemoveAt(i);
                    i--;
                }
                else
                {
                    dictionary.Add(list[i], true);
                }
            }

            Console.WriteLine($"[ {string.Join(", ", list)} ]");
            Console.WriteLine($"[ {string.Join(", ", dictionary)} ]");
        }
    }
}