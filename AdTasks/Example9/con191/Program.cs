// Запись в текстовый файл my.txt и чтение строк.

using System;
using System.IO; // подключаем пространство имен System.IO
class Program
{ 
    static void Main()
    { 
        string s1 = "Привет"; int a = 15; int b = 12;
        // создаем объект класса StreamWriter, открываем файл на дозапись
        StreamWriter fw = new StreamWriter(@"C:\Users\KAA\Documents\GIT\C-\AdTasks\Example9\con191\my.txt", true);
        // записываем строки 1 и 2
        fw.WriteLine("1: Работа с файлом"); fw.WriteLine("2: "+ s1);
        // добавляем строки 3, 4, 5
        fw.Write("3: a = " + a); fw.WriteLine(", b = " + b); // строка 3
        fw.WriteLine("4: 'a + b' = " + a + b); // строка 4
        fw.WriteLine("5: a + b = " + (a + b)); // строка 5
        fw.Close(); // закрываем записанный файл
        // создаем объект класса StreamReader – открываем файл на чтение
        StreamReader fr = new StreamReader("C:\\Users\\KAA\\Documents\\GIT\\C-\\AdTasks\\Example9\\con191\\my.txt");
        string str; int i = 0;
        while ( (str = fr.ReadLine()) != null)
        Console.WriteLine("{0} - {1} ", ++i, str );
        fr.Close(); // закрываем прочитанный файл
        Console.ReadKey();
    }
}