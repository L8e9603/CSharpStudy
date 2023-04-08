using System;

namespace ArrayInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];  // int 자료형인 원소를 가지고, 이름이 number인 배열 선언
                                        // 그 배열은 공간이 3개

            string[][] classrooms = new string[3][]; /// string[][] classrooms -> string 배열을 원소로 가지는 배열 classrooms 선언
                                                     /// new string[3][] -> classrooms 배열은 공간이 3개인 배열이다
                                                     /// 
            int classIndex = 0; // 0번째 == 1반
            string[] studentNames = classrooms[classIndex]; // 1반에 접근
        }
    }
}