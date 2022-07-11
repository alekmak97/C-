// Использование регулярных выражений

using System;
// подключаем пространство имен System.Text.RegularExpressions
using System.Text.RegularExpressions;

// Разбиение текста на слова.
// задаем исходную строку и шаблон разделителя
string tеxt = " cалат - 4 руб, борщ - 10 руб, чай - 1 руб.";
string reg = "[-,.]+";
Regex r = new Regex(reg); // создаем объект класса Regex
// разбиваем строку на слова по шаблону
string[] words = r.Split(tеxt);
foreach ( string wrd in words ) Console.WriteLine(wrd);
Console.ReadKey();
