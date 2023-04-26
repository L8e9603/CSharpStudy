using System;

namespace StaticMethod
{
    public class CourseCode
    {
        #region 생성자
        public CourseCode(ESubject subject, ushort number)
        {
            Subject = subject;
            Number = number;
        }
        #endregion

        #region 멤버 변수, 프로퍼티
        public ESubject Subject { get; private set; }

        public ushort Number { get; private set; }
        #endregion

        #region 멤버 함수
        /// <summary>
        /// 들어온 문자열을 과목과 번호로 나누고, 생성자 호출시켜 개체 생성 후 반환시키는 메서드
        /// </summary>
        /// <param name="courseCodeString"></param>
        /// <returns></returns>
        public static CourseCode Parse(string courseCodeString)
        {
            string subjectString = courseCodeString.Substring(0, 4);
            ESubject subject = Enum.Parse<ESubject>(subjectString);

            string numberString = courseCodeString.Substring(4);
            ushort number = ushort.Parse(numberString);

            return new CourseCode(subject, number); // 정적 멤버 함수로 생성자 호출시켜 개체 생성 후 반환

        }
        #endregion
    }
}
