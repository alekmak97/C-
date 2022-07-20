using System;
using System.Linq;
using System.Text;
using System.Net.Http;

namespace Ex25
{
    class Program
    {
        static public void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                Console.WriteLine($"Hello, {args[0].Replace("-","")}!");
            }
            Console.ReadKey(); 
        }
    }
}
/*
Запуск в cmd - \bin\Debug\net6.0\Ex25.exe -Aleksey
или
Создать ярлык exe и дописать концовку после exe : -Aleksey
*/