// Задан массив дней недели. По введенному порядковому номеру выводится название дня недели и количество дней до Вс.
void t1()
{
    string[] dw = {"Пн","Вт","Ср","Чт","Пт","Сб","Вс"};
    Console.WriteLine("Введите номер дня недели: ");
    int nd = int.Parse(Console.ReadLine());
    Console.WriteLine("День недели: {0}, до Вс {1} дн", dw[nd-1], dw.Length - nd);
}
t1();

// Заданы диагонали мониторов в дюймах: 10.1, 11.6, 14, 15.6, 17, 19, 24, 27. Формируется и выводится таблица перевода диагоналей в сантиметры.
void t2()
{
    double[] d = {10.1,11.6,14,15.6,17,19,24,27};
    double[] l = new double[d.Length];
    double c = 2.54;
    for (int i = 0; i < d.Length; i++)
    {
        l[i] = d[i] * c;
        Console.WriteLine("{0} д. = {1:f1} см", d[i], l[i]);
    }
}
t2();

// Формируется массив из 7 целых двузначных чисел путем ввода с клавиатуры. Выводится этот массив, четные числа и их количество. ( for, foreach )
void t3()
{
    int[] a = new int[7];
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(10, 100);
        Console.Write("a[{0}] = {1}; ", i, a[i]);
    }
    Console.WriteLine();
    Console.WriteLine("Чётные числа: ");
    foreach (int x in a)
    {
        if (x % 2 == 0)
        {
            Console.Write("{0}; ", x);
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество чётных чисел: {0}", count);
}
t3();

// Формируется массив из n натуральных нечетных чисел. Выводится исходный массив и числа кратные 3. ( for, foreach )
void t4()
{
    Console.WriteLine("Введите количество элементов массива, n: ");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    int A = 0;
    for (int i = 0; i < a.Length; i++)
    {
        while (i <a.Length)
        {
            A = new Random().Next(-50, 50);
            if (A % 2 > 0) break;            
        }
        a[i] = A;
        Console.Write("a[{0}] = {1}; ", i, a[i]);
    }
    Console.WriteLine();
    Console.WriteLine("Числа, кратные 3: ");
    foreach (int x in a)
    {
        if (x % 3 == 0)
        {
            Console.Write("{0}, ", x);
        }
    }
}
t4();

// Формируется массив из n целых случайных чисел от 10 до 99. Выводится исходный массив, нечетные числа и их количество. ( for, foreach )
void t5()
{
    Console.WriteLine("Введите количество элементов массива, n: ");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(10, 100);;
        Console.Write("a[{0}] = {1}; ", i, a[i]);
    }
    Console.WriteLine();
    Console.WriteLine("Нечётные числа: ");
    foreach (int x in a)
    {
       if (x % 2 > 0)
        {
            Console.Write("{0}, ", x);
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество нечётных чисел: {0}", count);    
}
t5();

// Формируется массив из n целых случайных чисел от -50 до 50. Массив упорядочивается. Выводятся числа в интервале от – 20 до +20.
void t6()
{
    Console.WriteLine("Введите количество элементов массива, n: ");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-50, 51);;
        Console.Write("a[{0}] = {1}; ", i, a[i]);
    }
    Console.WriteLine();
    Array.Sort(a);
    Console.WriteLine("[-20:20]");
    foreach (int x in a)
    {
        if (x >= -20 && x <= 20) Console.Write("{0}  ", x);
    }
}
t6();

// Формируется массив из n целых случайных чисел от -40 до 40. Выводятся нечетные отрицательные числа и их к-во. ( for, foreach )
void t7()
{
   Console.WriteLine("Введите количество элементов массива, n: ");
   int n = int.Parse(Console.ReadLine());
   int[] a = new int[n];
   int count = 0;
   for (int i = 0; i < a.Length; i++)
   {
       a[i] = new Random().Next(-40, 40);;
       Console.Write("a[{0}] = {1}; ", i, a[i]);
   }
   Console.WriteLine();
   foreach (int x in a)
   {
       if ((x < 0) && (x % 2 != 0))
       {
           Console.Write("{0}  ", x);
           count++;
       }
   }
   Console.WriteLine();
   Console.WriteLine("Количество нечётных чисел: {0}", count);
}
t7();


// Формируется массив из n целых случайных чисел от -50 до 50. Выводятся положительные числа в порядке убывания и их количество.
void t8()
{
    Console.WriteLine("Введите количество элементов массива, n: ");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
      a[i] = new Random().Next(-50, 50);;
      Console.Write("a[{0}] = {1}; ", i, a[i]);
    }
    Console.WriteLine();
    Array.Sort(a);
    Array.Reverse(a);
    Console.WriteLine("Положительные числа в обратном порядке: ");
    foreach (int x in a)
    {
        if (x >= 0)
        {
            Console.Write("{0}  ", x);
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество положительных чисел: {0}", count);
}
t8();

//Заданы массивы названий и обозначений транспортных средств, а также их скоростей, например: a – автомобиль, 70 км/ч; v – велосипед, 12 км/ч;
// m - мотоцикл, 60 км/ч; p – поезд, 90 км/ч; s – самолет, 800 км/ч). По введенному обозначению транспортного средства выводится его название и скорость.
void t9()
{
    string[] a = {"b","c","m","t","a"};
    string[] b = {"bicycle","car","motorbike","train","airplane"};
    string[] c = {"12 kmh","70 kmh","60 kmh","90 kmh","800 kmh"};
    string name = string.Empty;
    int index = 0;
    while (true)
    {
        Console.WriteLine("Введите обозначение транспортного средства (b, c, m, t, a) или quit для выхода: ");
        name = Console.ReadLine();
        if (name == "quit") break;
        if ((name != "b")  && (name != "c") && (name != "m") && (name != "t") && (name != "a"))
        {
            Console.WriteLine("Транспортное средство отсутствует в базе");
            continue;
        }
        for (int i = 0; i < a.Length; i++)
        {
            index = i;
            if (a[i] == name) break;
        }
        Console.WriteLine("Транспортное средство: {0}, Скорость: {1}", b[index], c[index]);
    }
}
t9();

// * По введенному порядковому номеру месяца и дате выводится: название месяца, количество дней в нем, количество дней, оставшихся до конца текущего месяца, название следующего месяца.
void t10()
{
    string[] m = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
    int[] d = {31,28,31,30,31,30,31,31,30,31,30,31};
    int number = 0;
    int i = 0;
    int date = 0;
    int year = 0;
    int nextmonth = i + 1;
    int dif = 0;
    string onoff = string.Empty;
    while (true)
    {
        Console.WriteLine("Введите номер месяца или quit для выхода: ");
        onoff = Console.ReadLine();
        if (onoff == "quit") break;
        Console.WriteLine("Год высокосный? (1 - да, 0 - нет): ");
        year = int.Parse(Console.ReadLine());
        number = int.Parse(onoff);
        i = number - 1;
        if (year == 1) { d[1]=29; }
        else { d[1]=28; }
        Console.WriteLine("Введите число месяца: ");
        date = int.Parse(Console.ReadLine());
        nextmonth = i + 1;
        if (number == 12) { nextmonth = 0; }
        dif = d[i]-date;
        Console.WriteLine("Месяц: {0}, Количество дней: {1}, до конца месяца {2}, Следующий месяц: {3}", m[i], d[i], dif, m[nextmonth]);
    }
}
t10();
