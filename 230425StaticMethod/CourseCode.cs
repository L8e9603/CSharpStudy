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
        /// <returns>CourseCode</returns>
        public static CourseCode Parse(string courseCodeString)
        {
            // 생성자의 매개변수로 필요한 데이터 파싱
            string subjectString = courseCodeString.Substring(0, 4);
            ESubject subject = Enum.Parse<ESubject>(subjectString);

            string numberString = courseCodeString.Substring(4);
            ushort number = ushort.Parse(numberString);

            return new CourseCode(subject, number); // 생성자 호출시켜 개체 생성 후 반환
        }

        /// <summary>
        /// 문자열을 받아 CourseCode 개체로 변환하는 메서드
        /// </summary>
        /// <param name="courseCodeString"></param>
        /// <param name="courseCode"></param>
        /// <returns>true: 변환 성공시<br>false: 변환 실패시</br></returns>
        public static bool TryParse(string courseCodeString, out CourseCode courseCode) 
        {
            courseCode = null; // 실패시 null을 리턴하기 위해 초기값으로 null을 넣어 줌

            if (string.IsNullOrWhiteSpace(courseCodeString) || courseCodeString.Length != 8) // 들어온 문자열 검사
            {
                return false; // 들어온 문자열이 null이나 빈 문자열, 또는 8글자가 아니라면 false 반환
            }

            string subjectString = courseCodeString.Substring(0, 4);
            ESubject subject;

            if (!Enum.TryParse(subjectString, out subject)) // 문자열을 과목 정보로 읽는데 실패했다면 false 리턴
            {
                // Parse 성공하면 true를 리턴하고, subjectString의 값이 Enum타입인 ESubject타입으로 변환되어 들어감
                // out 매개변수는 참조에 의한 전달이 이루어지므로 subject 매개변수는 위에서 선언했던 ESubject subject의 원본 값이 바꾼다
                // 참조에 의한 전달 때문에 ESubject subject을 TryParse 밖에서 선언했는데도 TryParse 함수 내부에서 subject의 값 변경이 일어나면 원본도 바뀜
                return false;
            }

            string numberString = courseCodeString.Substring(4);
            ushort number;

            if (!ushort.TryParse(numberString, out number))
            {
                return false;
            }

            courseCode = new CourseCode(subject, number);
            return true;

        }
        #endregion
    }
}
