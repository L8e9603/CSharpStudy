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

            string[][] calendar = new string[MONTHS_IN_A_YEAR][]; // string배열을 원소로 가지는 배열 calendar에 12개 공간 만들기

            for (int i = 0; i < MONTHS_IN_A_YEAR; i++)
            {
                calendar[i] = new string[daysInEachMonth[i]]; // 바깥 배열의 각 요소(1~12월)를 문자열 배열로 초기화, 문자열 배열의 길이는 제각각임
            }

            while (true) // 무한 루프 시작
            {
                // month 입력 받기
                Console.Write("Enter the Month (1 - 12) : "); // month 물어보기, 1 - 12 사이의 수여야 함
                string monthString = Console.ReadLine(); // 사용자에게 입력받은 값을 monthString 문자열 변수에 대입
                int month = int.Parse(monthString); // 입력받은 문자열을 int로 파싱 후 정수형 변수 month에 대입

                if (0 >= month || month > 12) // month가 1 - 12 사이의 값이 아니면 while문 종료
                {
                    Console.WriteLine("Invalid range of month. Terminating program.");
                    break;
                }


                // day 입력 받기
                Console.Write($"Enter the Day (1 - {calendar[month - 1].Length}) : "); // 입력받은 month의 값에 따라 Day의 범위 출력 해줌
                string dayString = Console.ReadLine();
                int day = int.Parse(dayString);

                if (0 >= day || day > calendar[month - 1].Length) // day가 month에 따른 범위가 아니면 while문 종료
                {
                    Console.WriteLine("Invalid range of day. Terminating program.");
                    break;
                }


                // 선택한 month와 day에 스케줄 입력
                Console.Write("Enter your schedule : ");
                string schedule = Console.ReadLine();
                calendar[month - 1][day - 1] = schedule;


                // 등록된 모든 스케줄 출력
                Console.WriteLine("---------------------------------------------------------");
                for (int i = 0; i < MONTHS_IN_A_YEAR; i++) // month 순회
                {
                    for (int j = 0; j < calendar[i].Length; j++) // month에 해당하는 day의 길이만큼 순회
                    {
                        if (!string.IsNullOrEmpty(calendar[i][j])) // 비어있지 않은 요소 출력
                        {
                            Console.WriteLine($"{i + 1} / {j + 1} : {calendar[i][j]}\n");
                        }
                    }
                }
            }
        }
    }
}