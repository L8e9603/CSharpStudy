using System;
using System.IO; // 파일 입출력

namespace ReadAndWriteFile
{
    class Program
    {
        #region VARIABLE
        // 정적 변수 정의
        // readonly 키워드가 적용된 변수는 값을 한 번 대입하면 다른 값을 대입하지 못함, 읽기 전용이 됨
        private static readonly string CURRENT_DIRECTORY = Directory.GetCurrentDirectory(); // exe 파일이 존재하는 디렉토리 절대경로 리턴됨
        private static readonly string OUTPUT_FOLDER_PATH = Path.Combine(CURRENT_DIRECTORY, "output");
        private static readonly string INTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "input", "inputtext.txt");
        private static readonly string OUTPUT_FILE1_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");
        private static readonly string OUTPUT_FILE2_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext2.txt");
        #endregion

        #region MAIN FUNCTION
        static void Main(string[] args)
        {
            setup();

            Console.WriteLine($"Input file is in: {INTPUT_FILE_FULL_PATH}"); // 이 경로에 저장된 파일을 곧 읽을 것임

            string allText = File.ReadAllText(INTPUT_FILE_FULL_PATH); // 파일을 하나의 문자열 변수에 읽어들임, '\n' 포함됨

            IEnumerable<string> strings = File.ReadLines(INTPUT_FILE_FULL_PATH);

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(allText);
            Console.WriteLine("-------------------------------------------------------------");

            string[] allLines = File.ReadAllLines(INTPUT_FILE_FULL_PATH); // 파일의 각 줄을 문자열 배열의 요소 하나로 읽어들임

            Console.WriteLine("-------------------------------------------------------------");

            foreach (string line in allLines)
            {
                Console.WriteLine(line);
            }
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine($"Output file 1 is in: {OUTPUT_FILE1_FULL_PATH}"); // 입력 파일로부터 읽어들인 것을 다른 출력 파일에 저장

            File.WriteAllText(OUTPUT_FILE1_FULL_PATH, allText);

            File.WriteAllLines(OUTPUT_FILE1_FULL_PATH, allLines); // 기존 파일이 있디면 덮어씀

            File.AppendAllLines(OUTPUT_FILE1_FULL_PATH, allLines); // 덮어쓰지 않고 추가로 내용을 덧붙임

            // 바이트들을 파일에 저장해보기
            byte[] bytes = new byte[12] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100, 33 };

            File.WriteAllBytes(OUTPUT_FILE2_FULL_PATH, bytes);

            Console.WriteLine($"Output file 2 is in: {OUTPUT_FILE2_FULL_PATH}"); 
        }
        #endregion
        #region CUSTOM FUNCION
        /// <summary>
        /// 프로그램 실행 전 출력 파일들을 지우고 출력 디렉터리가 없는 경우 그 디렉터리를 생성하는 메서드
        /// </summary>
        private static void setup() // private 메서드는 낙타표기법 사용
        {
            if (File.Exists(OUTPUT_FILE1_FULL_PATH))
            {
                File.Delete(OUTPUT_FILE1_FULL_PATH); // outputtext1.txt가 존재하면 지움
            }

            if (File.Exists(OUTPUT_FILE2_FULL_PATH))
            {
                File.Delete(OUTPUT_FILE2_FULL_PATH); // outputtext2.txt가 존재하면 지움
            }

            if (!Directory.Exists(OUTPUT_FOLDER_PATH))
            {
                Directory.CreateDirectory(OUTPUT_FOLDER_PATH); // 출력 폴더가 존재하지 않으면 생성함 (출력 파일을 만들 때 디텍터리가 존재하지 않으면 프로그램이 크래시가 남)
            }
        }
        #endregion
    }
}
