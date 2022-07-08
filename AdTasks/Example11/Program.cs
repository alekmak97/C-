// Генерируется случайное целое число n в интервале [ 20 – 99 ]. Проверяется, делится ли оно на введенное с клавиатуры целое число d (используйте тернарный оператор).
void t1()
{
    int n = new Random().Next(20, 100);
    Console.WriteLine("n = {0}", n);
    Console.Write("Введите число d, d = ");
    int d = int.Parse(Console.ReadLine());
    string mes = (n % d == 0) ? "Остаток отсутствует" : "Остаток присутствует";
    Console.WriteLine(mes);
}
t1();

// Генерируются два случайных целых числа a и b в интервале [10 – 30]. Если a > b, выводится их разность, eсли a < b, выводится сумма, eсли a == b, выводится сообщение “числа равны”. (оператор if)
void t2()
{
    int a = new Random().Next(10, 31);
    int b = new Random().Next(10, 31);
    Console.WriteLine("a = {0}, b = {1}", a, b);
    if (a>b) Console.WriteLine("a - b = {0}", a-b);
    if (a<b) Console.WriteLine("a + b = {0}", a+b);
    if (a==b) Console.WriteLine("a = b");
}
t2();

// Генерируются два случайных целых числа c и d в интервале [-10 – 10]. 
// Если оба числа четные, выводится их частное, если оба нечетные - их сумма, если одно число четное, а другое нечетное, выводится их произведение ( if ),
void t3()
{
    int c = new Random().Next(-10, 11);
    int d = new Random().Next(-10, 11);
    Console.WriteLine("c = {0}, d = {1}", c, d);
    if ((c % 2 == 0) && (d % 2 == 0)) Console.WriteLine("c - d = {0}", c-d);
    else if ((c % 2 == 1) && (d % 2 == 1)) Console.WriteLine("c + d = {0}", c+d);
    else Console.WriteLine("c * d = {0}", c*d);
}
t3 ();

// По введенному номеру месяца выводится название поры года (зима, весна, лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр ( if ).
void t4()
{
    string inimes = "Введите номер месяца, где 1 - январь, 2 - февраль, 3 - март, 4 - апрель, 5 - май, 6 - июнь, 7 - июль, 8 - август, 9 - сентябрь, 10 - октябрь, 11 - ноябрь, 12 декабрь";
    Console.WriteLine(inimes);
    Console.Write("Номер месяца: ");
    int month = int.Parse(Console.ReadLine());
    if (month==12 || month==1 || month==2) Console.WriteLine("Зима");
    if (month==3 || month==4 || month==5) Console.WriteLine("Весна");
    if (month==6 || month==7 || month==8) Console.WriteLine("Лето");
    if (month==9 || month==10 || month==11) Console.WriteLine("Осень");
    if (month==7 || month==8 ) Console.WriteLine("Каникулы");
    if (month==1 || month==6 ) Console.WriteLine("Сессия");
    if (month==9 || month==10 || month==11 || month==12) Console.WriteLine("Семестр 1");
    if (month==2 || month==3 || month==4 || month==5) Console.WriteLine("Семестр 2");
}
t4();

// Проверяется соответствие веса и роста (ввод рост и вес; вывод одного из сообщений "Норма", "Нужно похудеть", "Нужно поправиться". Нормальный вес (в кг) = (рост (в см) – 100) ± 10%. (оператор if )
void t5()
{
    Console.WriteLine("Введите рост, см: ");
    double l = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите вес, кг: ");
    double w = double.Parse(Console.ReadLine());
    if (w > (l-100)*1.1) Console.WriteLine("Нужно похудеть");
    else if (w < (l-100)*0.9) Console.WriteLine("Нужно поправиться");
    else Console.WriteLine("Норма");
}
t5();

// Введенная цифра (от 0 до 5) выводится прописью (оператор switch)
void t6()
{
    Console.Write("Number [0:5]: ");
    int n = int.Parse(Console.ReadLine());
    string mes=string.Empty;
    switch (n)
    {
        case 0: mes = "Zero"; break;
        case 1: mes = "One"; break;
        case 2: mes = "Two"; break;
        case 3: mes = "Three"; break;
        case 4: mes = "Four"; break;
        case 5: mes = "Five"; break;
    }
    Console.WriteLine(mes);
}
t6();

// Выводится название предмета по введенной первой букве: ф - физика, м - математика, и - история, г - география, б - биология (оператор switch)
void t7()
{
    Console.Write("Write first char of lesson: ");
    string l = Console.ReadLine();
    string mes=string.Empty;
    switch (l)
    {
        case "ф": mes = "Физика"; break;
        case "м": mes = "Математика"; break;
        case "и": mes = "История"; break;
        case "г": mes = "География"; break;
        case "б": mes = "Биология"; break;
        default: mes = "Такого предмета нет"; break;
    }
    Console.WriteLine(mes);
}
t7();

// Выводится название страны и ее столицы по введенной первой букве: б – Беларусь, Минск, р – Россия, Москва, л –Литва, Вильнюс (switch)
void t8()
{
    Console.Write("Write first char of country: ");
    string c1 = Console.ReadLine();
    string c2 = c1.ToLower();
    string mes=string.Empty;
    switch (c2)
    {
        case "б": mes = "Беларусь, Минск"; break;
        case "р": mes = "Россия, Москва"; break;
        case "л": mes = "Литва, Вильнюс"; break;
        default: mes = "Страны нет в базе"; break;
    }
    Console.WriteLine(mes);
}
t8();

// По введенному номеру выводится название дня недели (1 – пн, 2 –вт,...) и сообщение “рабочий день” или “выходной” (операторы switch, if)
void t9()
{
    Console.Write("Номер дня недели: ");
    int day = int.Parse(Console.ReadLine());
    string mes=string.Empty;
    switch (day)
    {
        case 1: mes = "Monday"; break;
        case 2: mes = "Tuesday"; break;
        case 3: mes = "Wednesday"; break;
        case 4: mes = "Thursday"; break;
        case 5: mes = "Friday"; break;
        case 6: mes = "Saturday"; break;
        case 7: mes = "Sunday"; break;
        default: mes = "Дня недели не существует"; break;
    }
    Console.WriteLine(mes);
    if (day >= 1 && day <= 5) Console.WriteLine("Рабочий день");
    if (day == 6 || day == 7) Console.WriteLine("WeekEnd");
}
t9();

// Проверяется правильность введенного логина строго из 5 букв и пароля из 6 и более цифр
void t10()
{
    Console.Write("Login: ");
    string login = Console.ReadLine();
    if (login.Length != 5)
    {
        Console.WriteLine("login is uncorrected");
    }
    else
    {
        Console.Write("Password: ");
        string pass = Console.ReadLine();
        long password = 0;
        if ((!long.TryParse(pass, out password)) || pass.Length < 6)
        {
            Console.WriteLine("Password is uncorrected"); password = 0;
        }
        else
        {
            password = long.Parse(pass);
            Console.WriteLine("Hello friend!");
            Console.WriteLine(password);
        }
    }
}
t10();
