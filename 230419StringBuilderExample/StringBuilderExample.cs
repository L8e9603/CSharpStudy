using System;
using System.Text; // StringBuilder 클래스 사용

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 1000;
            StringBuilder stringBuilder = new StringBuilder(CAPACITY); // 용량이 1000인 StringBuilder 객체 생성

            stringBuilder.Append("Hello World!");
            stringBuilder.AppendLine(" Welcome to COMP1500"); // stringBuilder.Append(" Welcome to COMP1500\n")과 실행결과가 같음
            stringBuilder.AppendLine("Are you having fun yet?");

            Console.WriteLine(stringBuilder.ToString()); // string 자료형으로 변환됨
            // Console.WriteLine(stringBuilder); // StringBuilder 클래스 객체 자체를 출력해도 출력되긴 함, 단, 이 경우 string 자료형이 아님의 유의

            stringBuilder.Insert(12, " Going to insert this here.");
            Console.WriteLine(stringBuilder.ToString());

            stringBuilder.Replace(" Going to insert this here.", " And replace this.");
            Console.WriteLine(stringBuilder.ToString());

            stringBuilder.Remove(12, 19);
            Console.WriteLine(stringBuilder.ToString());

            stringBuilder.Clear(); // null 아님, 빈 문자열 상태
            Console.WriteLine(stringBuilder.ToString());

        }

    }
}