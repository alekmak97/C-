// Проверка телефонного номера вида NNN-NN-NN.
using System;
// подключаем пространство имен System.Text.RegularExpressions
using System.Text.RegularExpressions;
class Program
    {
    static void Main()
        {
        Console.WriteLine("Введите номер телефона");
        String str= Console.ReadLine();
        // создаем шаблон регулярного выражения
        String reg = @"^\d{3}[ -]\d{2}[ -]\d{2}$";
        // проверяем совпадение введенной строки с шаблоном
        if (Regex.IsMatch(str, reg))
        Console.WriteLine("{0} похоже", str);
        else Console.WriteLine("{0} ошибка", str);
        Console.ReadKey();
        }
    }