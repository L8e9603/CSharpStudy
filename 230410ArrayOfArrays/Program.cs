// 원하는 날짜에 메모를 적게 해주는 캘린더 프로그램
using System;

namespace ArrayOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MONTHS_IN_A_YEAR = 12; // 상수 선언해주면 코드 읽기 편하다
            int[] daysInEachMonth = new int[MONTHS_IN_A_YEAR] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string[][] calendar = new string[MONTHS_IN_A_YEAR][]; // 바깥배열 12개 공간 만들기

        }
    }
}