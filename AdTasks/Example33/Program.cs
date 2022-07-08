// Задан массив дней недели. По введенному порядковому номеру выводится название дня недели и количество дней до Вс.
void t1()
{
    string[] dw = {"Пн","Вт","Ср","Чт","Пт","Сб","Вс"};
    Console.WriteLine("Введите номер дня недели: ");
    int nd = int.Parse(Console.ReadLine());
    Console.WriteLine("День недели: {0}, до Вс {1} дн", dw[nd-1], dw.Length - nd);
}
// t1();


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
// t2();

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
// t3();

// Формируется массив из n натуральных нечетных чисел. Выводится исходный массив и числа кратные 3. ( for, foreach )
void t4()
{
    
}