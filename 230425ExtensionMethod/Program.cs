using System;

namespace ExtensionMethod
{
    class Program
    {
        public struct Vector2
        {
            public int X { get; set; } = 1;

            public Vector2()
            {
                
            }
        }

        static void Main(string[] args)
        {
            const string HELLO_WORLD = "Hello World!";

            string reversedString = HELLO_WORLD.Reverse(); // string의 메서드인 것 처럼 개체에서 닷 연산자로 Reverse() 메서드에 접근 가능하다
            Console.WriteLine(reversedString);

            string reversedString2 = HELLO_WORLD.Reverse(2, 8);
            Console.WriteLine(reversedString2);

        }
    }
}