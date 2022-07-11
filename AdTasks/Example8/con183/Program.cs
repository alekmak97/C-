// Замена фрагментов текста.

using System;
// подключаем пространство имен System.Text.RegularExpressions
using System.Text.RegularExpressions;

// задаем исходную строку и шаблоны
string tеxt = "телефон 400 рб, часы 120 грн, компьютер 560 $";
string reg = "рб|грн|\\$"; // шаблон для поиска
string zam = "руб"; // шаблон для замены
// выполняем поиск и замену по шаблонам и сразу вывод
Console.WriteLine(Regex.Replace(tеxt, reg, zam));
Console.ReadKey();
