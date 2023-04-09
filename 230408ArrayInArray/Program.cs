using System;

namespace ArrayInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1차원 배열 만들기
            int[] number = new int[3];  // int[] number -> int 자료형 원소(int)를 가지고 이름이 number 배열공간([])을 만들어주세요, int가 number 배열의 원소!!
                                        // new int[3] -> 그 배열 공간의 길이를 3개로 설정한다

            // 배열속 배열 만들기
            // 1. 바깥 배열 만들기
            const int CLASS_COUNT = 3;
            string[][] classrooms = new string[CLASS_COUNT][]; /// string[][] classrooms -> string 배열을 원소로 가지는 배열 classrooms 선언, string[]이 classrooms 배열의 원소!!
                                                               /// new string[3][] -> 그 classrooms 배열 공간의 길이를 CLASS_COUNT개로 설정한다
                                                               /// 안쪽 배열의 길이는 길이를 정의하지 않았기 때문에 .Length 찍어보면 null이라고 뜬다, 노션 2023.04.10 월 | 안쪽 배열 만들기 참고
            // 2. 안쪽 배열 만들기
            int[] STUDENT_COUNT_PER_CLASS = { 3, 2, 5 };
            
            for (int i = 0; i < CLASS_COUNT; i++)
            {
                classrooms[i] = new string[STUDENT_COUNT_PER_CLASS[i]]; // i==0일 때 첫 번째 바깥 배열 원소는 길이가 3인 string배열을 원소로 가진다
            }
            
            classrooms[0] = new string[3]; // 위 for문과 동일한 의미
            classrooms[1] = new string[2];
            classrooms[2] = new string[5];

            int classIndex = 0;     // 1반
            int studentIndex = 0;   // 첫 번째 학생

            string[] studentNames = classrooms[classIndex];
            studentNames[studentIndex] = "Severus";

            Console.WriteLine(studentNames.Length); // 안쪽 배열을 만들었기 때문에 길이를 알 수 있다
            Console.WriteLine($"Class 1 - Student 1 : {classrooms[classIndex][studentIndex]}"); // new로 만든 것은 참조형 데이터이기 때문에 34번 라인처럼 대입해도 원본 제어가 가능하다
        }
    }
}