using System;

namespace DefaultParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar("POCU");
            Bar("POCU", "COMP1500");
            Bar("POCU", "COMP1500", "Programming");
        }
        
        static void Bar(string s, string s2 = "", string s3 = "")
        {
             Console.WriteLine($"{s}, {s2}, {s3}");
        }
    }
}