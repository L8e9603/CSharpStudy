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

            Console.WriteLine($"[ {string.Join(", ", list)} ]"); // ', ' 구분자로 리스트 내용 출력

            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6 }; // 요소들을 직접 적어서 초기화 가능

            Console.WriteLine($"[ {string.Join(", ", list2)} ]");

            Console.WriteLine($"First element: {list[0]}");
            Console.WriteLine($"Last element: {list[list.Count - 1]}");

            list.Insert(2, 2); // 색인 2 자리에 데이터 Insert

            Console.WriteLine($"[ {string.Join(", ", list)} ]");

            list.Remove(2); // 색인 0부터 시작해서 처음으로 만나는 2라는 요소를 삭제

            Console.WriteLine($"[ {string.Join(", ", list)} ]");

            bool bContains5 = list.Contains(5);

            Console.WriteLine($"Contains 5? {bContains5}");

            bool bContains10 = list.Contains(10);

            Console.WriteLine($"Contains 10? {bContains10}");

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}