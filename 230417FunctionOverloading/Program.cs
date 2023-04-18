using System;

namespace FunctionOverloading
{
    class Program
    {
        static void Main()
        {
            int score = 1;
            Print(score);

            string name = "Sun";
            Print(name);
        }
        
        static void Print(int score)
        {
            Console.WriteLine(score);
        }

        static void Print(string name)
        {
            Console.WriteLine(name);
        }
    }
}