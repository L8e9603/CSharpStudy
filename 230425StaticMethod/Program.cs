using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // 생성자를 이용한 인스턴스 생성
            CourseCode courseCode1 = new CourseCode(ESubject.COMP, 3200);
            Console.WriteLine($"{courseCode1.Subject}{courseCode1.Number}"); // 개체 생성 확인

            // Parse() 정적 함수를 이용한 인스턴스 생성
            CourseCode courseCode2 = CourseCode.Parse("MATH1100");
            Console.WriteLine($"{courseCode2.Subject}{courseCode2.Number}");

            // CourseCode.Parse("What is this madness!"); // 매개변수에 들어가는 문자열을 잘못 입력하면 뻑난다

            // TryParse() 정적 함수를 이용한 인스턴스 생성
            CourseCode courseCode3;
            bool bParsed = CourseCode.TryParse("What is this madness!", out courseCode3); // 잘못된 과목코드
            Console.WriteLine($"Parsed result: {bParsed}");

            CourseCode courseCode4;
            bParsed = CourseCode.TryParse("COMP9900", out courseCode4); // 올바른 과목코드
            Console.WriteLine($"{courseCode4.Subject}{courseCode4.Number}");

        }
    }
}