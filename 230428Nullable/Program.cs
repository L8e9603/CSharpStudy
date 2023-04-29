using System;
using System.Linq;

namespace Nullable
{
    class Program
    {
        #region MAIN FUNCTION

        static void Main(string[] args)
        {
            // foos 배열 안에 Foo 개체들 생성
            Foo[] foos = new Foo[]
            {
                new Foo(1),
                new Foo(2), // foos[1].Number == 2
                new Foo(3),
            };

            // Number 프로퍼티가 2인 foo 개체 찾기
            Foo foo1 = First(foos, 2);

            if (foo1 == null)
            {
                Console.WriteLine($"foo1 is null!");
            }
            else
            {
                Console.WriteLine($"foo1: {foo1.Number}"); // 위에서 foos 배열 안에 Number 프로퍼티가 2인 foo 개체를 생성했으므로 현재 라인 else 블록 진입
            }

            // Number 프로퍼티가 4인 foo 개체 찾기
            Foo foo2 = First(foos, 4);

            if (foo2 == null)
            {
                Console.WriteLine($"foo2 is null!"); // foos 배열 안에 Number 프로퍼티가 4인 foo 개체가 없으므로  현재 라인 if 블록 진입
            }
            else
            {
                Console.WriteLine($"foo2: {foo2.Number}"); 
            }

            // Bar 개체들 생성
            Bar[] bars = new Bar[]
            {
                new Bar(1),
                new Bar(2),
                new Bar(3)
            };

            // Bar bar1 = First(bars, 2); // First() 함수는 Nullable 값 리턴, Nullable 값을 값형인 Bar 구조체에 대입 할 수 없다
            Bar? bar2 = First(bars, 2); // bar2 개체는 Nullable형이기 때문에 null을 대입할 수 있다, 그러나 Number 프로퍼티가 2인 Bar 개체를 찾을 수 있어서 null이 대입되지는 않음

            if (bar2 == null)
            {
                Console.WriteLine($"bar2 is null!");
            }
            else
            {
                Console.WriteLine($"bar2: {bar2.Value.Number}"); // bar2 개체는 Nullable이기 때문에 Number를 출력하려면 .Value로 접근해야함
            }

            Bar? bar3 = First(bars, 4);

            if (bar3 == null)
            {
                Console.WriteLine($"bar3 is null!"); // bar3은 null
            }
            else
            {
                Console.WriteLine($"bar3: {bar3.Value.Number}");
            }

        }
        #endregion

        #region CUSTOM FUNCTION
        /// <summary>
        /// Find number in foos
        /// </summary>
        /// <param name="foos"></param>
        /// <param name="number"></param>
        /// <returns>Foo class if found number in foos otherwise null</returns>
        public static Foo First(Foo[] foos, int number)
        {
            foreach(Foo foo in foos)
            {
                if (foo.Number == number)
                {
                    return foo; // foos 배열에서 매개변수 number와 일치하는 foo 개체를 찾으면 그 개체를 반환
                }
            }

            return null; // Foo는 클래스, 즉 참조형이기 때문에 null을 가질 수 있다
        }

        /// <summary>
        /// Find number in bars
        /// </summary>
        /// <param name="bars"></param>
        /// <param name="number"></param>
        /// <returns>Bar struct if found number in bar otherwise null</returns>
        public static Bar? First(Bar[] bars, int number) // Bar 구조체는 값형이기 때문에 null이 들어갈 수 없다, 반환값으로 Bar에 null을 넣기 위해 Nullable로 선언
        {
            foreach (Bar bar in bars)
            {
                if (bar.Number == number)
                {
                    return bar; // bars 배열에서 매개변수 number와 일치하는 bar 개체를 찾으면 그 개체를 반환
                }
            }

            return null; // Bar 구조체를 Nullable로 만들었기 때문에 값형이지만 null을 가질 수 있다
        }
        #endregion
    }
}