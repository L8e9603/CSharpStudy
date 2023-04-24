using System;
using System.Collections.Generic;
using DictionaryExample;

namespace ForeachLoop
{
    class Program
    {
        public Program()
        {

        }
        public Program(int num)
        {

        }
        static void Main(string[] args)
        {
            #region foreach 연습
            List<int> list = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(0, 10);
                list.Add(number);
            }

            int sum = 0;

            foreach (int i in list)
            {
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine("----------------------------\n");

            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                { "Key1", 1},
                { "Key2", 2},
                { "Key3", 3},
                { "Key4", 4},
                { "Key5", 5},
                { "Key6", 6},
            };


            // foreach (KeyValuePair<string, int> entry in dictionary)
            foreach (var entry in dictionary) // var 키워드 : 묵시적 자료형, 컴파일러가 자료형 추론, 지역변수에서만 사용 가능, 선언과 동시에 대입 필요
            {
                Console.WriteLine($"{entry.Key}, {entry.Value}");
            }

            Console.WriteLine("----------------------------\n");
            #endregion

            #region 해시셋을 이용한 중복 제거 알고리듬
            List<string> customers = new List<string>() { "Pope", "Bob", "Ruin", "Rich", "John", "Doe", "Riven", "Pope" };
            customers.Add("Pope");
            customers.Add("Bob");
            customers.Add("Riven");
            customers.Add("Ruin");
            customers.Add("John");

            HashSet<string> filteredCustomers = new HashSet<string>();

            foreach (string customer in customers)
            {
                filteredCustomers.Add(customer);
            }

            Console.WriteLine($"[ {string.Join(", ", filteredCustomers)} ]");
            #endregion

            #region 클래스 연습
            Program2 program2 = new Program2();
            program2.Main("");
            #endregion
        }
    }
}