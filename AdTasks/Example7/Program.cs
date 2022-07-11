// Работа сo строками

// Использование методов класса String.
void con171()
{
    string str = "прекрасная королева";
    Console.WriteLine(str); // вывод
    //выделяем подстроку str2, удаляем символы “ле”
    string str2 = str.Substring(3).Remove(12, 2);
    Console.WriteLine(str2); // вывод: красная корова
    // расщепляем строку str в массив слов mas (разделитель – пробел)
    string[] mas = str.Split(' ');
    // выводим все слова s массива mas
    foreach (string s in mas) Console.WriteLine(s);
    Array.Sort(mas); // сортируем слова массива mas по алфавиту
    foreach (string s in mas) Console.WriteLine(s); // вывод
    // соединяем слова массива mas в одну строку str3
    string str3 = string.Join(" !!! моя ", mas);
    Console.WriteLine(str3); // вывод: королева !!! моя прекрасная
    string str4 = str3.Replace("!", "?"); // заменяем все ! на ?
    Console.WriteLine(str4); // вывод: королева ??? моя прекрасная
    // определяем позицию k вхождения подстроки моя
    int k = str4.IndexOf("моя");
    //удаляем из строки str4 символы начиная с k-го до конца
    string str5 = str4.Remove(k);
    Console.WriteLine(str5); // вывод: королева ???
    Console.ReadKey();
}
con171();