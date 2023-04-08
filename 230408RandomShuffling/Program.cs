// Fisher-Yates shuffle 알고리듬
using System;

namespace RandomShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SEED = 0;
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.Write("Before Shuffling : ");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");

            Random random = new Random(SEED); // 정해진 시드값으로 Random 클래스형 변수 생성

            for (int i = numbers.Length - 1; i > 0; i--) // number 배열의 길이 -1 만큼 반복
            {
                int j = random.Next(0, i); // i는 numbers 배열의 인덱스를 의미하고, 반복할 때마다 1씩 줄어듦, j에는 섞을 숫자의 배열 인덱스 저장
                int temp = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = temp;
            }

            Console.Write("After Shuffling : ");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}