using System;

namespace PassByValue
{
    public class PassByValue
    {
        static void Main()
        {
            double number = 5;

            SquareRef(ref number);
            
            SquareValue(number);
            
            Console.WriteLine(number);
        }

        static void SquareValue(double number)
        {
            number *= number;
        }

        static void SquareRef(ref double number)
        {
            number *= number;
        }
    }
}
