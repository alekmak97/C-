// Ветвление

// Пример 1. Использование конструкции if ... else, для проверки знака и четности введенного числа
void con111()
{
    string mes1 = "", mes2 = ""; // объявление и инициализация
    Console.WriteLine("Введите целое число ");
    // ввод строки и преобразование в целое число
    int n = int.Parse(Console.ReadLine());
    if (n>=0) mes1 ="положительное";
    else mes1 = "отрицательное";
    if (n%2==0) mes2 = "четное";
    else mes2 = "нечетное";
    Console.WriteLine("Число {0} {1} {2}", n, mes1, mes2);
    Console.ReadKey();
}
con111();

// Пример 2. Использование тернарного оператора для проверки знака и четности случайного числа
void conn112()
{
    Random rnd = new Random(); // создаем экземпляр класса Random
    // генерируем случайное целое число в интервале -40, 40
    int n = rnd.Next(-40, 40);
    // используем тернарный оператор
    string mes1 = (n >= 0) ? "положительное" : "отрицательное";
    string mes2 = (n % 2 == 0) ? "четное" : "нечетное";
    Console.WriteLine("Число {0} {1} {2}", n, mes1, mes2);
    Console.ReadKey();
}
conn112();

// Пример 3. Использование конструкции выбора switch...case
void con113()
{
    string mes;
    Console.WriteLine("Введите день недели: Пн, Вт, Ср, Чт, Пт, Сб, Вс");
    string day = Console.ReadLine();
    switch (day)
    { 
        case "Сб": mes = "Иду в гости"; break;
        case "Вс": mes = "Отдыхаю"; break;
        default: mes = "Работаю"; break;
    }
    Console.WriteLine(mes);
    Console.ReadKey();
}
con113();

// Пример 4*. Проверка логина и пароля, введенных с клавиатуры
// Пусть эталонные логин длиной не меньше 6 символов и пароль хранятся в строковых переменных myLog и myPas в коде программы. 
// Сначала проверяем длину и совпадение введенного логина с заданным. В случае правильности логина проверяем совпадение пароля.
void con114()
{
    // задаем эталонные логин и пароль, а также выводимые сообщения
    string myLog = "qwerty", myPas = "asdf";
    string mes = "", mesYes = "Добро пожаловать!", mesNo = "Вход воспрещен!";
    Console.Write("Введите логин: ");
    string log = Console.ReadLine(); // вводим логин
    // проверяем длину и совпадение логина
    if (log.Length < 6) mes = "Логин очень короткий!\n" + mesNo;
    else if (log != myLog) mes = "Неверный логин!\n" + mesNo;
    else
    // в случае истинности логина вводим и проверяем пароль
    { 
        Console.Write("Введите пароль: ");
        string pas = Console.ReadLine(); // вводим пароль
        mes = (pas == myPas) ? mesYes : "Неверный пароль!\n" + mesNo;
    }
    Console.WriteLine(mes); // выводим сообщения
    Console.ReadKey();
}
con114();

// Пример 5*. Простейший калькулятор на 4 действия
void con115()
{
    // инициализируем переменные res и ok.
    double A, B, res=0; 
    bool ok=true;
    Console.Write("Введите число А: ");
    string sA = Console.ReadLine(); // ввод строки
    if (!double.TryParse(sA, out A)) // Проверка значения, присвоение 1, если не число
    { 
        Console.WriteLine("Не число!"); A = 1; 
    }
    else 
    {
        A = double.Parse(sA); // преобразование в число
    }
    Console.Write("Введите число B: ");
    string sB = Console.ReadLine();
    if (!double.TryParse(sB, out B)) // Проверка значения, присвоение 1, если не число
    { 
        Console.WriteLine("Не число!"); B = 1; 
    }
    else 
    {
        B=double.Parse(sB);
    }
    Console.Write("Введите знак операции (+-*/) ");
    string op = Console.ReadLine();
    switch (op)
    { 
        case "+": res = A + B; break;
        case "-": res = A - B; break;
        case "*": res = A * B; break;
        case "/": res = A / B; break;
        default: ok = false; break;
    }
    if (ok)
    Console.WriteLine("{0} {1} {2} = {3}", A, op, B, res); //вывод
    else Console.WriteLine("Недопустимая операция");
Console.ReadKey();
}
con115();