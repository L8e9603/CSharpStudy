using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int dividend = random.Next(); // 분자값 랜덤 생성

            // TryParse() 메서드를 사용하면 try/catch/finally 구문을 작성할 필요 없다
            try
            {
                Console.WriteLine($"Input a divisor?");
                string integerString = Console.ReadLine(); // 유저 입력 값을 분모로 사용
                int divisor = int.Parse(integerString);

                // 학습용 억지 커스텀 예외
                if (divisor == 10)
                {
                    throw new IntegerIs10Exception("The input interger is 10!");
                }

                double result = dividend / divisor;
                Console.WriteLine($"Result: {result}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Argument is null");
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Integer format is wrong");
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number is too huge to be an integer");
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("The dividend is being divided by 0");
                Console.WriteLine(e);
            }
            catch (IntegerIs10Exception e) // 커스텀 예외
            {
                Console.WriteLine("Divisor cannot be 10!");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally clause always runs regardless of whether or not there was an exception");
            }
        }
    }
}