using System;

namespace RecursiveFactorial
{
    class Program
    {
        #region BUILT IN METHOD
        static void Main(string[] args)
        {
            const ulong FACTORIAL = 10;
            
            Console.Write("NoneRecursiveFactorial : ");
            Console.WriteLine(NoneRecursiveFactorial(FACTORIAL));

            Console.Write("RecursiveFactorial : ");
            Console.WriteLine(RecursiveFactorial(FACTORIAL));
        }
        #endregion

        #region CUSTOM METHOD
        /// <summary>
        /// 반복문을 이용한 팩토리얼
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static ulong NoneRecursiveFactorial(ulong n)
        {
            if (n <= 1)
            {
                return 1;
            }

            uint factorial = 1;
            
            for (uint i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        /// <summary>
        /// 재귀 함수를 이용한 팩토리얼
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static ulong RecursiveFactorial(ulong n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * RecursiveFactorial(n-1); // 5! == 5 * 4! == 5 * 4 * 3! ==  5 * 4 * 3 * 2! == 5 * 4 * 3 * 2 * 1
        }
        #endregion
    }
}