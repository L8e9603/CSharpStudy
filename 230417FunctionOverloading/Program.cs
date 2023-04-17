using System;

namespace FunctionOverloading
{
    class Program
    {
        static void Main()
        {

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