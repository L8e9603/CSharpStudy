using System; // Console 클래스의 WriteLine() 메서드 사용을 위해 using 지시어로 System 라이브러리(C#에서는 namespace라고 함)를 사용한다고 알려주는 구문

namespace HelloWorld
{
    internal class HelloWorld
    {
        static void Main(string[] args) // 커맨드라인 인자, cmd에서 실행시 인자를 넣어줄 수 있음
        {
            Console.WriteLine("Hello World!"); // using 지시어로 System 라이브러리를 사용한다고 하였기 때문에 Console 클래스의 WriteLine() 메서드를 사용 가능
        }
    }
}
