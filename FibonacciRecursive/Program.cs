using System;

namespace FibonacciRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(20));
        }

        /// <summary>
        /// 피보나치 수열의 n번째 항을 반환하는 메서드
        /// </summary>
        /// <param name="number">number번째 항</param>
        /// <returns>n번째 항의 값</returns>
        static int Fibonacci(uint number)
        {
            // 종료조건 1
            if (number == 0) 
            {
                return 0;
            }

            // 종료조건 2
            if (number == 1) 
            {
                return 1;
            }

            // 재귀호출
            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }
    }
}