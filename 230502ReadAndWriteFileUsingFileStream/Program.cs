using System;
using System.IO;

namespace ReadAndWriteFileUsingFileStream
{
    public class Program
    {
        #region VARIABLES
        private static readonly string CURRENT_DIRECTORY = Directory.GetCurrentDirectory(); // exe 파일이 존재하는 디렉토리 절대경로 리턴됨
        private static readonly string OUTPUT_FOLDER_PATH = Path.Combine(CURRENT_DIRECTORY, "output");
        private static readonly string INTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "input", "inputtext.txt");
        private static readonly string OUTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");
        #endregion

        #region MAIN FUNCION

        static void Main(string[] args)
        {
            setup();

            FileStream fsRead = File.Open(INTPUT_FILE_FULL_PATH, FileMode.Open, FileAccess.Read); // FileStream을 이용하여 파일 속 컨텐츠 읽어오기
            // fsRead.Write(new byte[] { 1, 2, 3 }, 0, 3); //위 라인에서 Open() 할 때 FileAccess.Read 매개변수로 읽기 전용으로 설정했기 때문에 쓰려고 하면 예외 발생, 다른사람이 파일을 덮어쓰기 하는 것을 방지할 수 있음

            Console.WriteLine($"CanRead: {fsRead.CanRead}"); // 읽기와 쓰기 가능 여부가 FileAccess 매개변수에 의해 결정됨 FileAccess 매개변수를 쓰지 않으면 읽기, 쓰기 둘다 True
            Console.WriteLine($"CanWrite: {fsRead.CanWrite}");
            Console.WriteLine($"CanSeek: {fsRead.CanSeek}");
            Console.WriteLine();

            byte[] bytes = new byte[fsRead.Length]; // 파일 내용을 바이트 배열에 저장
            fsRead.Read(bytes, 0, bytes.Length);

            fsRead.Close(); // 다 사용했으면 반드시 스트림 닫아주기

            Console.Write("inputtext.txt to byte: ");
            Console.WriteLine(string.Join(", ", bytes));
            Console.WriteLine();

            Console.WriteLine("bytes to char");
            foreach (byte b in bytes)
            {
                Console.Write((char)b);
            }
            Console.WriteLine("\n");

            // 위에서 저장한 바이트를 출력 파일에 저장해보자
            FileStream fsWrite = File.Open(OUTPUT_FILE_FULL_PATH, FileMode.Create, FileAccess.Write);
            Console.WriteLine($"CanRead: {fsWrite.CanRead}"); // 읽기 불가능
            Console.WriteLine($"CanWrite: {fsWrite.CanWrite}");
            Console.WriteLine($"CanSeek: {fsWrite.CanSeek}");

            fsWrite.Write(bytes, 0, bytes.Length);
            fsWrite.Close();

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