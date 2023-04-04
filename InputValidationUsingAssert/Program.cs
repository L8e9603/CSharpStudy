using System;
using System.Diagnostics;

namespace InputValidationUsingAssert
{
    class Program // 유니티에서 스크립트에 해당, 클래스
    {
        static void Main(string[] args) // 모노 비헤이비어 상속된 유니티 스크립트의 Start 메서드와 비슷, 엔트리 포인트, Start 메서드는 모노 비헤이비어 클래스에 작성되어있음
        {
            double quotient1 = Divide(1, 2);
            // double quotient2 = Divide(1, 0); // 어서트 발생

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintRange(1, 5, numbers);
            PrintRange(5, 9, numbers);
            PrintRange(-6, 5, numbers); // 어서트 발생
        }

        static double Divide(int x, int y)
        {
            Debug.Assert(y != 0, "y cannot be 0"); // Debug.Log() 와 비슷한 기능, 어서트는 디버그 모드 런타임 중 condition이 false가 되면 프로그램 정지, 릴리즈 모드에서는 주석처리와 같음

            double quotient = x / (double)y;
            return quotient;
        }

        static void PrintRange(int start, int end, int[] numbers)
        {
            Debug.Assert(start >= 0, "start cannot be less than 0");
            Debug.Assert(end >= 0, "end cannot be less than 0");

            Console.Write("[");

            for (int i = start; i < end; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }

            Console.WriteLine(numbers[end] + "]");
        }
    }
}