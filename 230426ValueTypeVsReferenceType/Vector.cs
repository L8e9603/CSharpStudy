namespace ValueTypeVsReferenceType
{
    public class Vector
    {
        /// <summary>
        ///  생성자
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector(int x, int y) // 생성자도 메서드다
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// 프로퍼티
        /// </summary>
        public int X { get; set; } // 자동으로 구현된 프로퍼티, 컴파일러의 도움으로 내부적으로 mX같은 멤버 변수 생성되어 get, set으로 mX 제어
        public int Y { get; set; }
    }
}