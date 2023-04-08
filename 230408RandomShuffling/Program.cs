// Fisher-Yates shuffle 알고리듬
using System;

namespace RandomShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SEED = 0; // 없어도 됨
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.Write("Before Shuffling : ");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");

            Random random = new Random(SEED);

            for (int i = numbers.Length - 1; i > 0; i--) // 뒤에서부터 반복하는 반복문
            {
                int j = random.Next(0, i);
                int temp = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = temp;
            }

            Console.Write("After Shuffling :  ");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}