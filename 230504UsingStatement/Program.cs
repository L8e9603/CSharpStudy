using System;
using System.Collections.Generic;
using System.IO;

namespace UsingStatement
{
    class Program
    {
        #region FIELDS
        private static readonly string CURRENT_DIRECTORY = Directory.GetCurrentDirectory(); // exe 파일이 존재하는 디렉토리 절대경로 리턴됨
        private static readonly string OUTPUT_FOLDER_PATH = Path.Combine(CURRENT_DIRECTORY, "output");
        private static readonly string INTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "input", "inputtext.txt");
        private static readonly string OUTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");
        #endregion

        #region MAIN FUNCTION
        static void Main(string[] args)
        {
            setup();

            string allText = string.Empty;

            using (StreamReader reader1 = new StreamReader(File.Open(INTPUT_FILE_FULL_PATH, FileMode.Open, FileAccess.Read))) // File.Open()은 파일 모드에 따라 파일을 연 뒤 FileStream 반환
            {
                Console.WriteLine("-------------------------");
                allText = reader1.ReadToEnd();
                Console.WriteLine(allText);
                Console.WriteLine("-------------------------");
            }

            List<string> allLines = new List<string>();

            using (StreamReader reader2 = new StreamReader(File.Open(INTPUT_FILE_FULL_PATH, FileMode.Open, FileAccess.Read)))
            {
                allLines = new List<string>();
                while (!reader2.EndOfStream) // EndOfStream 프로퍼티는 스트림 끝까지 도달하면 true를 반환
                {
                    allLines.Add(reader2.ReadLine());
                }

                foreach(string line in allLines)
                {
                    Console.WriteLine(line);
                }
            }

            // using문을 이용한 파일 쓰기
            using (StreamWriter writer = new StreamWriter(File.Open(OUTPUT_FILE_FULL_PATH, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                writer.Write(allText);

                foreach(string line in allLines)
                {
                    writer.WriteLine(line);
                }
                Path.DirectorySeparatorChar + "dw"
                writer.BaseStream.Seek(0, SeekOrigin.Begin); // 스트림 위치 리셋되지 않음
                writer.Write("Overwritten Text");
            }
        }
        #endregion

        #region CUSTOM FUNCION
        /// <summary>
        /// 프로그램 실행 전 출력 파일들을 지우고 출력 디렉터리가 없는 경우 그 디렉터리를 생성하는 메서드
        /// </summary>
        private static void setup() // private 메서드는 낙타표기법 사용
        {
            if (File.Exists(OUTPUT_FILE_FULL_PATH))
            {
                File.Delete(OUTPUT_FILE_FULL_PATH); // outputtext.txt가 존재하면 지움
            }

            if (!Directory.Exists(OUTPUT_FOLDER_PATH))
            {
                Directory.CreateDirectory(OUTPUT_FOLDER_PATH); // 출력 폴더가 존재하지 않으면 생성함 (출력 파일을 만들 때 디텍터리가 존재하지 않으면 프로그램이 크래시가 남)
            }
        }
        #endregion
    }

}
}