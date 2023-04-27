using System;

namespace StaticClass
{
    public static class UnitConverter
    {
        public static double GetInchcesFromCentimeters(double centimeters)
        {
            return centimeters * 0.393701;
        }

        public static double GetCentimetersFromInchces(double inches)
        {
            return inches / 0.393701;
        }

        public static double GetMetersFromCentimeters(double centimeters)
        {
            return centimeters / 100;
        }

        public static double GetFeetFromInches(double inches)
        {
            return inches / 12;
        }

        // 정적 클래스는 개체를 만들 수 없다, 따라서 개체에 속한 멤버 함수를 만들어봐야 쓸 수 없기 때문에 정적이 아닌 함수들을 가질 수 없다
/*        public void SomeMethod()
        {
            Console.WriteLine("Won't compile");
        }
*/    
    }
}
