// Массивы

// Пример 1. Формирование и вывод массивов чисел.
void con131()
{
    Console.Write("Введите размерность массивов (от 5 до 20) ");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n]; int[] b = new int[n]; // объявление массивов
    for (int i = 0; i < n; i++)
    {
        a[i] = i; b[i] = a[i]*a[i]; // заполнение массивов
        Console.WriteLine("a[{0}] = {1}, b[{0}] = {2}", i, a[i], b[i] );
    }
    Console.ReadKey();
}
con131();

// Пример 2. Формирование и вывод массива строк.
void con132()
{
    // объявляем и заполняем массив дней недели
    string[] dw = {"Вс","Пн","Вт","Ср","Чт","Пт","Сб"};
    // выводим рабочие дни с помощью цикла for
    for (int i = 1; i < dw.Length - 1; i++)
        Console.WriteLine(i + " рабочий день " + dw[i]);
    // перебираем и выводим все элементы с помощью цикла foreach
    foreach (string day in dw)
        Console.WriteLine(day);
    // сначала только объявляем массив месяцев, затем заполняем два элемента
    string[] ms = new string[12];
    ms[6] = "Июль"; ms[7] = "Август";
    int j = 0;
    // перебираем и выводим элементы с помощью цикла foreach
    foreach (string m in ms)
        Console.Write("{0}-{1} ", ++j, m);
    Console.ReadKey();
}
con132();

// Пример 3. Свойства и методы класса Array.
void con133()
{
    Console.Write("Введите размерность массивов (от 5 до 20) ");
    int n = int.Parse(Console.ReadLine());
    Random r = new Random(); // создание экземпляра класса Random
    int[] a = new int[n]; // объявление массива
    for (int i = 0; i < n; i++)
    {
        a[i] = r.Next(-20, 20); //заполнение массива случайными числами
        Console.Write("{0,4}", a[i]); // вывод исходного массива
    }
    //подсчет суммы и количества отрицательных чисел
    int sum = 0, num = 0; // задание начальных значений
    foreach (int x in a)
        if (x < 0) { sum += x; num++; }
    Console.WriteLine("\n Сумма отрицательных = {0}, к-во = {1}", sum, num);
    // поиск максимального элемента
    int max = a[0];
    foreach (int x in a) if (x > max) max = x;
        Console.WriteLine("max = " + max);
    // сортировка элементов массива
    Array.Sort(a);
    foreach (int x in a) Console.Write("{0,4}", x);
    Console.WriteLine();
    // изменение порядка элементов массива
    Array.Reverse(a);
    foreach (int x in a) Console.Write("{0,4}", x);
    Console.ReadKey();
}
con133();