using System;
using System.IO;

namespace ParseTextMessage
{
    class Program
    {
        #region BUILT-IN METHOD
        static void Main(string[] args)
        {
            #region 문자열 토큰화 메서드 구현 연습, 문자 메세지 해석하기 기능 구현 전 연습
            string nameText = "Karen,Mary,Christina,Betty,Pope,Sun";

            foreach (var token in StringToTokens(nameText))
            {
                Console.WriteLine(token);
            }

            // Console.WriteLine(String.Join(Environment.NewLine, StringToTokens(nameText))); // 위 foreach문과 동일한 코드

            // Console.WriteLine(StringToTokens(nameText)); //배열을 출력하려한 코드지만 작동하지 않음, System.string[] 출력됨
            #endregion

            #region 문자 메세지 해석하기
            // string textMessage = File.ReadAllText(@"D:\이선재 보관파일\개인 공부\프로그래밍 개인공부\CSharp\CSharpStudy\230411ParseTextMessage\Resources\TextMessage.txt"); // 절대경로

            // string path = AppDomain.CurrentDomain.BaseDirectory; // 실행 프로그램 경로, 상위폴더로 세 번 올라가면 프로젝트 폴더임

            string textMessage = File.ReadAllText(@"..\..\..\Resources\TextMessage.txt"); // 상대경로
            string[] lines = textMessage.Split('\n'); // newline 캐릭터로 Split해서 lines 배열에 저장
            
            string[] dateTimeString = lines[1].Split(' '); // Monday 2019-04-15 13:21:54.456 를 공백 기준으로 Split해서 dateTimeString 배열에 저장
            string nameOfDay = dateTimeString[0]; // Split해서 저장한 배열의 첫 번째 원소는 Monday, 문자열 변수 nameOfDay에 저장
            
            string[] date = dateTimeString[1].Split('-'); // 2019-04-15 문자열을 '-' 캐릭터로 Split
            int year = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int day = int.Parse(date[2]);

            string[] time = dateTimeString[2].Split(':'); // 13:21:54.456 문자열을 ':' 캐릭터로 Split
            int hours = int.Parse(time[0]);
            int mins = int.Parse(time[1]);
            float seconds = float.Parse(time[2]);

            string email = lines[2].Trim(); // 빈칸 제거

            string courseCode = lines[3].Replace("Course", "").Trim(); // "Course		      COMP1500" 문자열에서 "Course" 문자열을 빈 문자열로 대체시키고 앞뒤 공백 제거시켜 "COMP1500" 문자열만 저장
            string term = lines[4].Replace("Term", "").Trim();

            Console.WriteLine($"Name of Day : {nameOfDay}");
            Console.WriteLine($"Year : {year}");
            Console.WriteLine($"Month : {month}");
            Console.WriteLine($"Day : {day}");
            Console.WriteLine($"Hours : {hours}");
            Console.WriteLine($"Minutes : {mins}");
            Console.WriteLine($"Seconds : {seconds}");
            Console.WriteLine($"Email : {email}");
            Console.WriteLine($"Course Code : {courseCode}");
            Console.WriteLine($"Term : {term}");
            #endregion
        }
        #endregion

        #region CUSTOM METHOD
        /// <summary>
        /// 문자열을 토큰화 시키는 메서드
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns>string 배열 리턴, 배열의 각 요소는 토큰</returns>
        static string[] StringToTokens(string plainText)
        {
            string[] tokens;
            string tempString = plainText;
            int commaCount = 0;

            // 콤마 개수를 알아내 토큰의 개수 파악
            while (tempString.IndexOf(',') != -1)
            {
                commaCount++;
                tempString = tempString.Substring(tempString.IndexOf(',') + 1);
            }

            tokens = new string[commaCount + 1]; // commaCount + 1 == 토큰의 개수, 토큰 개수만큼 배열 공간 잡기

            tempString = plainText; // for문에서 돌리기 위해 다시 초기화

            // 토큰 배열에 토큰 대입
            for (int i = 0; i < commaCount + 1; i++)
            {
                if (tempString.IndexOf(',') != -1) // 문자열에 콤마가 있다면
                {
                    tokens[i] = tempString.Substring(0, tempString.IndexOf(',')); // 토큰 배열에 콤마 전까지 잘라넣고
                    tempString = tempString.Substring(tempString.IndexOf(',') + 1); // 콤마 이후 문자열 잘라내 대입
                }
                else // 마지막 토큰 도달
                {
                    tokens[i] = tempString;
                }
            }

            return tokens;
        }
    }
    #endregion
}