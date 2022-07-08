// Вычисляется сумма всех нечетных натуральных чисел от n1 до n2 (n1 и n2 вводятся с клавиатуры, цикл for).
void t1()
{
    Console.WriteLine("Введите n1: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n2: ");
    int n2 = int.Parse(Console.ReadLine());
    int min, max; int sum = 0;
    if (n1 > n2) 
    {
        max = n1; 
        min = n2;
    }
    else
    {
        max = n2; 
        min = n1;
    }
    if (max != min)
    {
        for (int i = min; i <= max; i++)
        {
            if (i % 2 != 0) sum += i;
        }
    }
    Console.WriteLine("sum = {0}", sum);
}
t1();

// Вычисляется сумма квадратов n натуральных чисел, начиная с k (вводятся k и n, цикл for).
void t2()
{
    Console.WriteLine("Введите n: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k: ");
    int k = int.Parse(Console.ReadLine());
    int sum = 0, kk = k;
    for (int i = 0; i < n; i++)
    {
        int kv = kk*kk;
        sum += kv;
        kk++;
    }
    Console.WriteLine("sum = {0}", sum);
}
t2();

// Вычисляется и выводится в таблицу с шагом 10 км стоимость поездки на автомобиле в зависимости от расстояния S (10 – 90 км). 
// С клавиатуры вводятся: b - расход бензина на 100 км, c - цена бензина за 1л литр. (цикл for)
void t3()
{
    Console.WriteLine("Введите расход бензина на 100 км, л: ");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите стоимость бензина за 1л, руб: ");
    double c = double.Parse(Console.ReadLine());
    double price = 0;
    for (double S = 10; S <= 90; S=S+10)
    {
        price = S/100*b*c;
        Console.WriteLine("Расстояние = {0} км, Стоимость = {1} руб", S, price);
    }
}
t3();

// В интервале [0, 2 c] с шагом 0.1с вычисляются координаты y = V0*t–g*t*t/2 и скорости V = V0–gt мячика, брошеного вертикально вверх с начальной скоростью V0 (V0 вводится с клавиатуры, цикл for).
void t4()
{
    Console.WriteLine("Введите V0: ");
    double V0 = double.Parse(Console.ReadLine());
    double g = 9.8;
    double y = 0;
    double V = 0;
    for (double t = 0.1; t <= 2.09; t = t + 0.1)
    {
        V = V0 - g*t;
        y = V0*t - g*t*t/2;
        Console.WriteLine("Время = {0:f1} с, Скорость = {1:f2} м/с, Расстояние = {2:f2} м ", t, V, y);
    }
}
t4();

// Повторяются вычисления и вывод площади круга по вводимому радиусу r до тех пор, пока не введена буква z или Z.
void t5()
{
    string rad = string.Empty;
    double r, s, pi = 3.14;
    while (true)
    {
        Console.WriteLine("Введите r: ");
        rad = Console.ReadLine().ToLower();
        if (rad == "z") break;
        r = double.Parse(rad);
        s = pi*r*r;
        Console.WriteLine("Площадь = {0:f2} кв.м.", s);
    }
}
t5();

// Генерируется 8 случайных чисел в интервале (– 30, 30). Выводятся эти числа и сообщения: отрицательное – положительное, четное – нечетное ( for, if ).
void t6()
{
    int[] a = new int[8];
    string mes1 = string.Empty;
    string mes2 = string.Empty;
    for (int i = 0 ; i < a.Length; i++)
    {
        a[i] = new Random().Next(-30, 30);
        mes1 = (a[i] >= 0) ? "положительное" : "отрицательное";
        mes2 = (a[i] % 2 == 0) ? "четное" : "нечетное";
        Console.WriteLine("Число {0}, {1}, {2}", a[i], mes1, mes2);
    }
}
t6();

// Генерируется 10 случайных чисел в интервале (– 20, 20). Выводятся только положительные числа и сообщения: четное - нечетное ( for, if ).
void t7()
{
    int[] a = new int[10];
    string mes = string.Empty;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-20, 20);
        mes = (a[i] % 2 == 0) ? "четное" : "нечетное";
        if (a[i] >= 0)
        {
            Console.WriteLine("Число {0}, {1}", a[i], mes);
        }
    }
}
t7();

// Генерируются случайные числа в интервале (– 40, 40) до тех пор, пока очередное число не превышает 30. Выводятся только нечетные числа и сообщения: отрицательное – положительное ( while, if ).
void t8()
{
    int A = 0;
    while (A <= 30)
    {
        A = new Random().Next(-40, 40);
        if (A % 2 != 0)
        {
            string mes = (A >= 0) ? "положительное" : "отрицательное";
            Console.WriteLine("Число {0}, {1}", A, mes);
        }
    }
}
t8();

// Генерируются случайные числа в интервале (0, 20) до тех пор, пока их сумма не превысит S (вводится с клавиатуры).
// Нумеруются и выводятся эти числа и их сумма ( while, if ).
void t9()
{
    Console.WriteLine("Введите S: ");
    int S = int.Parse(Console.ReadLine());
    int sum = 0;
    int i = 1;
    int A = 0;
    while (S >= sum)
    {
        A = new Random().Next(0, 20);
        sum = sum + A;
        Console.WriteLine("{0}. A = {1}, sum = {2}", i, A, sum);
        i++;
    }
}
t9();

// Ежедневно количество бактерий увеличивается на p процентов. Через сколько дней количество бактерий увеличится в n раз (ввод p и n ).
void t10()
{
    Console.WriteLine("Введите p: ");
    double p = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите n: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Количество бактерий сейчас: ");
    double k_init = double.Parse(Console.ReadLine());
    double k = k_init;
    int day = 0;
    double ratio = 0;
    do
    {
        k = k * (100+p)/100;
        ratio = k / k_init;
        day++;
    } while (n > ratio);
    Console.WriteLine("Количество бактерий увеличится в {0} раз через {1} дн.", n, day);
}
t10();
