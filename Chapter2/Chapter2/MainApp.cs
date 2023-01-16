using System;
using static System.Console;

namespace Chapter2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("사용법: Chapter2.exe <이름>");
                return;
            }

            WriteLine("Hello {0}!", args[0]);
            WriteLine($"===${nameof(Practice1)}===");
            Practice1();
        }

        static void Practice1()
        {
            WriteLine("여러분, 안녕하세요?\n반갑습니다!");
        }
    }
}