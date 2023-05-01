using System;
using System.IO; // 파일 입출력

namespace ReadAndWriteFile
{
    class Program
    {
        private static readonly string CURRENT_DIRECTORY = Directory.GetCurrentDirectory(); // exe 파일이 존재하는 디렉토리 절대경로 리턴됨
        private static readonly string OUTPUT_FOLDER_PATH = Path.Combine(CURRENT_DIRECTORY, "output");
        private static readonly string INTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "input", "inputtext.txt");
        private static readonly string OUTPUT_FILE1_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");
        private static readonly string OUTPUT_FILE2_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext2.txt");

        static void Main(string[] args)
        {
            setup();
        }

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
    }
}
