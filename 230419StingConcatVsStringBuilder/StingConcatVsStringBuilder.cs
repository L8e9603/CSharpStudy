// + 연산자를 이용한 문자열 이어붙이기와 StringBuilder를 이용한 문자열 이어붙이기 속도를 비교하는 프로그램
using System;
using System.Diagnostics; // Stopwatch 클래스 사용
using System.Text; // StringBuilder, Concatenation 클래스 사용

namespace StingConcatVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LOOP_COUNT = 1000;

            Stopwatch stopwatch = new Stopwatch();

            #region USING_CONCATENATION
            stopwatch.Start();

            string concatenated = string.Empty;
            for (int i = 0; i < LOOP_COUNT; i++)
            {
                concatenated += "test";
            }

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed in ms (Concatenated): {stopwatch.Elapsed.TotalMilliseconds})");
            #endregion

            stopwatch.Reset();

            #region
            StringBuilder stringBuilder = new StringBuilder(4096);
            for (int i = 0; i < LOOP_COUNT; i++)
            {
                stringBuilder.Append("test");
            }

            string s = stringBuilder.ToString();

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed in ms (StringBuilder): {stopwatch.Elapsed.TotalMilliseconds})");
            #endregion
        }
    }
}