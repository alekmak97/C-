// Работа с символами

// Определение категории введенного символа.
void con161()
{
    int k; char ch; string mes = ""; //объявление переменных
    do { 
        // повторение ввода в цикле с постусловием
        Console.WriteLine("Введите символ: ");
        k = Console.Read(); ch = (char)k; // ввод и преобразование кода в символ
        // проверка категории символа
        if (char.IsLetter(ch)) mes = "буква";
        else if (char.IsDigit(ch)) mes = "цифра";
        else if (char.IsPunctuation(ch)) mes = "знак пунктуации";
        else mes = "управляющий символ";
        Console.WriteLine("Введен символ {0}, его код {1}, это {2}", ch, k, mes);
        } while (ch != 'Q'); // завершение цикла при вводе буквы Q
    Console.ReadKey();
}
con161();

// Подсчет количества и суммы всех содержащихся в строке цифр.
void con162()
{
    Console.WriteLine("Введите строку: ");
    string str = Console.ReadLine(); // ввод строки
    int k = 0, sum = 0; // задание начальных значений
    foreach (char s in str) // перебор всех символов строки
    {
        if (char.IsDigit(s)) //если очередной символ цифра,
        { 
            k++; sum += s-48; //считаем к-во и сумму цифр
            Console.Write(s +" "); //выводим цифры
        }
    }
    Console.WriteLine("\nВ строке {0} цифр, их сумма = {1}", k, sum);
    Console.ReadKey();
}
con162();

// Перестановка соседних символов строки.
void con163()
{
    Console.WriteLine("Введите строку: ");
    string str = Console.ReadLine();
    int k = str.Length-1; // определение длины строки
    string str2 = ""; // объявление новой пустой строки
    // сформируем строку str2 c переставленными соседними символами
    for (int i = 0; i < k ; i += 2)
    { 
        str2 += str[i+1]; str2 += str[i]; 
    }
    // добавим финальный нечетный символ (с четным индексом)
    if (k % 2 == 0) str2 += str[k];
    Console.WriteLine(str2); //вывод строки str2
    Console.ReadKey();
}
con163();

// Работа с массивом символов. Использование методов класса Array.
void con164()
{
    Console.WriteLine("Введите строку: ");
    string str = Console.ReadLine(); // ввод строки
    // преобразование строки в массив символов
    char[] ch = str.ToCharArray();
    Array.Reverse(ch); Console.WriteLine(ch); // реверсирование и вывод
    Array.Sort(ch); Console.WriteLine(ch); // сортировка и вывод
    Console.ReadKey();
}
con164();
