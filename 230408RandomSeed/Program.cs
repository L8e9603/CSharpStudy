using System;

namespace RandomSeed
{
    class Program
    {
        static void Main()
        {
            Random random = new Random(); // 시드가 없다면 자동으로 컴퓨터의 시간을 시드값으로 이용함
            Console.WriteLine(random.Next(0, 10));
        }
    }
}