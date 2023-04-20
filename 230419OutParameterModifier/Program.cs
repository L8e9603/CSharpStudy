using System;

namespace OutParameterModifier
{
    class Program
    {
        #region BUILT-IN METHOD

        static void Main(string[] args)
        {
            // 입력받은 문자열을 불리언형으로 파싱하기
            Console.Write("Enter \"true\" or \"false\" : ");
            string booleanString = Console.ReadLine();

            bool b; // 초기화되지 않은 변수를 매개변수로 넘겨줄 수 있다, 메서드에서 초기화 하기 때문, Raycast의 out 매개변수가 그 예
            if (bool.TryParse(booleanString, out b))
            {
                Console.WriteLine($"Successfully parsed : {b}\n");
            }
            else
            {
                Console.WriteLine($"Cannot be parsed to boolean\n");
            }

            // 입력받은 문자열을 정수형으로 파싱하기
            Console.Write("Enter an integer : ");
            string intString = Console.ReadLine();

            int number;
            if (int.TryParse(intString, out number))
            {
                Console.WriteLine($"Successfully parsed : {number}\n");
            }
            else
            {
                Console.WriteLine($"Cannot be parsed to integer\n");
            }


            // Try메서드 만들기
            Console.Write("Let's Play a Game\nEnter an integer : ");
            string intString2 = Console.ReadLine();
            int someNumber;
            if (int.TryParse(intString2, out someNumber))
            {
                int randomNumber; // 메서드에서 초기화 하기 때문에 여기서 초기화 해줄 필요 없음, out 키워드와 함께 매개변수로 전달, 참조에 의한 전달

                if (TryGetIntegerGreaterThan(someNumber, out randomNumber))
                {
                    Console.WriteLine($"You Win!\nYour number : {someNumber}\nRandom number : {randomNumber}");
                }
                else
                {
                    Console.WriteLine($"You Lose\nYour number : {someNumber}\nRandom number : {randomNumber}");
                }
            }
            else
            {
                Console.WriteLine($"Cannot be parsed to integer\n");
            }
        }
        #endregion

        #region CUSTOM METHOD
        /// <summary>
        /// 사용자가 입력한 값과 실행마다 발생하는 랜덤값을 비교하는 메서드<br></br>
        /// 사용자 입력값이 더 크면 true 리턴
        /// </summary>
        /// <param name="intput"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        static bool TryGetIntegerGreaterThan(int intput, out int output)
        {
            var random = new Random();

            output = random.Next(intput - 100, intput + 100);

            return intput > output;
        }
        #endregion
    }
}