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