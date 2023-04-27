using System;
using System.Text;

namespace ExtensionMethod
{
    public static class StringExtensions
    {
        /// <summary>
        /// 문자열을 뒤집는 메서드
        /// </summary>
        /// <param name="s"></param>
        /// <returns>string</returns>
        public static string Reverse(this string s)
        {
            StringBuilder stringBuilder = new StringBuilder(s.Length);

            for(int i = s.Length - 1; i >= 0; i--) // 역순으로 도는 반복문
            {
                stringBuilder.Append(s[i]);
            }

            return stringBuilder.ToString();
        }
        /// <summary>
        /// 특정 구간 문자열만 뒤집는 메서드
        /// </summary>
        /// <param name="s"></param>
        /// <param name=""></param>
        /// <returns>string</returns>
        public static string Reverse(this string s, int start, int end)
        {
            if (start < 0 || end > s.Length || start > end - 1)
            {
                return s; // 매개변수가 조건을 만족하지 못하면 문자열 그대로 반환
            }

            StringBuilder stringBuilder = new StringBuilder(s.Length);
            
            // start 위치 이전 글자들은 순서 안바뀜
            for (int i = 0; i < start; i++)
            {
                stringBuilder.Append(s[i]);
            }

            // start와 end 사이 문자열 뒤집기
            for (int i = end - 1; i >= start; i--)
            {
                stringBuilder.Append(s[i]);
            }

            // end 부터 마지막 문자까지 그대로 붙이기
            for (int i = end; i < s.Length; i++)
            {
                stringBuilder.Append(s[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
