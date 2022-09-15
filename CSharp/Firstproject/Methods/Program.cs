using System;

namespace Methods
{
    internal class Program
    {
        // 함수 정의
        // 반환타입 함수이름(매개변수1탑입 매개변수1이름, 매개변수2타입 매개변수2이름 ...)
        // {
        //     ...
        //     연산내용
        //     ...
        //     retuen 반환값;
        // }
        //
        // void 반환형 함수에서는 함수 마지막에 return 을 생략할 수 있다.
        static void Main(string[] args)
        {
            // 함수 호출 형태
            // 함수이름(인자1, 인자2 ...);
            PrintHelloWorld();
            PrintNum(3);
            int result = 0;
            result = Sum(1, 2);
            PrintNum(result);
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintNum(int num)
        {
            Console.WriteLine(num);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
