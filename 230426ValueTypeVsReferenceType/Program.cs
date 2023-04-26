using System;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            // 값에 의한 전달 발생
            int num = 0;
            Increment(num); 
            Console.WriteLine(num);

            // 참조에 의한 전달 발생
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Increment(nums);
            Console.WriteLine(string.Join(",", nums));

            // 참조에 의한 전달 발생
            Vector vector = new Vector(0, 0);
            Increment(vector); 
            Console.WriteLine($"{vector.X}, {vector.Y}");


            #region 클래스 스왑 연습
            // 스왑됨
            Vector vector1 = new Vector(1, 1);
            Vector vector2 = new Vector(2, 2);
            Vector temp = vector1;
            vector1 = vector2;
            vector2 = temp;
            Console.WriteLine($"{vector1.X}, {vector1.Y}");
            Console.WriteLine($"{vector2.X}, {vector2.Y}");

            // 스왑 안됨
            Vector vector3 = new Vector(3, 3);
            Vector vector4 = new Vector(4, 4);
            SwapVector(vector3, vector4);
            Console.WriteLine($"{vector3.X}, {vector3.Y}");
            Console.WriteLine($"{vector4.X}, {vector4.Y}");

            // 스왑됨
            Vector vector5 = new Vector(5, 5);
            Vector vector6 = new Vector(6, 6);
            SwapVector(ref vector5, ref vector6);
            Console.WriteLine($"{vector5.X}, {vector5.Y}");
            Console.WriteLine($"{vector6.X}, {vector6.Y}");
            #endregion
        }

        /// <summary>
        /// 값에 의한 전달이 이루어지는 함수
        /// </summary>
        /// <param name="num"></param>
        public static void Increment(int num)
        {
            num++;
        }

        /// <summary>
        /// 참조에 의한 전달이 이루어지는 함수
        /// </summary>
        /// <param name="nums"></param>
        public static void Increment(int[] nums) // 배열은 참조형 데이터
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]++;
            }
        }

        /// <summary>
        /// 참조에 의한 전달이 이루어지는 함수
        /// </summary>
        /// <param name="nums"></param>
        public static void Increment(Vector vector) // 클래스는 참조형 데이터
        {
            vector.X++;
            vector.Y++;
        }

        public static void SwapVector(Vector vector1, Vector vector2) // 함수 호출후 함수 내부에서만 스왑됨
        {
            Vector temp = vector1;
            vector1 = vector2;
            vector2 = temp;
        }

        public static void SwapVector(ref Vector vector1,ref Vector vector2) // 함수 호출 끝나도 정상적으로 스왑 됨
        {
            Vector temp = vector1;
            vector1 = vector2;
            vector2 = temp;
        }
    }
}