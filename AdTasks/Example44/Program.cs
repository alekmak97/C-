// Задан прямоугольный массив названий и обозначений транспортных средств, (a – автомобиль, v – велосипед, m - мотоцикл, p – поезд, s – самолет).
// По введенному обозначению транспортного средства выводится его название
void t1()
{
    string[,] table = 
    {
        {"b","c","m","t","a"},
        {"bicycle","car","motorbike","train","airplane"},
        {"12 kmh","70 kmh","60 kmh","90 kmh","800 kmh"}
    };
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
        for (int i = 0; i < table.GetLength(1); i++)
        {
            index = i;
            if (table[0,i] == name) break;
        }
        Console.WriteLine("Транспортное средство: {0}, Скорость: {1}", table[1,index], table[2,index]);
    }
}
t1();

// Формируется и выводится прямоугольный массив (5 строк и 6 столбцов) целых случайных чисел от -40 до 40. 
// Вычисляется и выводится: а) сумма чисел в каждой строке; б) среднее арифметическое чисел в каждой строке;
void t2()
{
    int[,] table = new int[5,6];
    double [,] sum_A = new double[table.GetLength(0),2];
    double A = 0; 
    Console.WriteLine("table = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-40, 41);
            Console.Write("{0,5}", table[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("sum_A = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum_A[i,0] = sum_A[i,0] + table[i,j];
            sum_A[i,1] = sum_A[i,0] / (j+1);
        }
        Console.WriteLine("{0} строка: Sum = {1}, A = {2:f2}", i+1, sum_A[i,0], sum_A[i,1]);
    }
}
t2();

// Формируется и выводится прямоугольный массив (n строк и m столбцов) целых случайных чисел от -50 до 50. Вычисляется и выводится: 
// а) среднее арифметическое отрицательных чисел в каждой строке; 
// в) сумма и среднее арифметическое положительных четных чисел в каждой строке; 
// д) сумма и среднее арифметическое всех чисел.
void t3()
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    int[,] table = new int[n,m];
    double sum1, sum2, SUM=0;
    double a1, a2, A=0;
    int a11, a22;
    Console.WriteLine("table = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-50, 51);
            Console.Write("{0,5}", table[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        sum1 = 0; sum2 =0; a1 = 0; a2 = 0; a11 = 0; a22 = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i,j] < 0)
            {
                sum1 = sum1 + table[i,j];
                a11++;
            }
            if (table[i,j] >= 0)
            {
                sum2 = sum2 + table[i,j];
                a22++;
            }
            SUM = SUM + table[i,j];
            A = SUM /((i+1) * (j+1));
        }
        a1 = sum1 / a11;
        a2 = sum2 / a22;
        Console.WriteLine("{0} строка: ", i+1);
        Console.WriteLine("Сумма отрицательных чисел = {0}, Среднеарифметическое отрицательных чисел = {1:f2}, Количество отрицательных чисел = {2}", sum1, a1, a11);
        Console.WriteLine("Сумма положительных чисел = {0}, Среднеарифметическое положительных чисел = {1:f2}, Количество положительных чисел = {2}", sum2, a2, a22);
        Console.WriteLine();
    }
    Console.WriteLine("Сумма всех чисел = {0}, Среднеарифметическое всех чисел = {1:f2}, Количество всех чисел = {2}", SUM, A, n*m);
}
t3();

// Формируется и выводится прямоугольный массив - таблица умножения двух чисел от 1 до 10.
void t4()
{
    int[,] table = new int[10,10];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = (i+1)*(j+1);
            Console.Write("{0,5}", table[i,j]);
        }
        Console.WriteLine();
    }
}
t4();

// Формируется и выводится прямоугольный массив (6 строк и 8 столбцов) целых случайных чисел от -70 до 70. 
// Вычисляется и выводится: а) максимальный элемент в каждой строке; б) минимальный положительный элемент в каждой строке.
void t5()
{
   int[,] table = new int[6,8];
    Console.WriteLine("table = ");
    int max, min_plus;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-70, 71);
            Console.Write("{0,5}", table[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        max = -100; min_plus = 100;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i,j] > max) max = table[i,j];
            if (table[i,j] >= 0 && table[i,j] < min_plus) min_plus = table[i,j];
        }
        Console.WriteLine("{0} строка: ", i+1);
        Console.WriteLine("Max = {0}, Min_plus = {1}", max, min_plus);
        Console.WriteLine();
    }
    Console.WriteLine(); 
}
t5();

// Формируется и выводится прямоугольный массив (n строк и m столбцов) целых случайных чисел от -90 до 90. 
// Вычисляется и выводится: а) минимальный из всех отрицательных элементов; б) максимальный из модулей всех элементов массива.
void t6()
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    int[,] table = new int[n,m];
    int a = -100;
    int b = 0;
    Console.WriteLine("table = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-90, 91);
            Console.Write("{0,5}", table[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i,j] < 0 && table[i,j] > a) a = table[i,j];
            if (Math.Abs(table[i,j]) > b) b = Math.Abs(table[i,j]);
        }
    }
    Console.WriteLine("Минимальный элемент из всех отрицательных элементов = {0}, Максимальный элемент из модулей всех элементов массива = {1}", a, b);
}
t6();

// * Формируется и выводится прямоугольный массив (n строк и m столбцов) целых случайных чисел от -80 до 80. 
// а) в каждой строке находится минимальный элемент и заменяется нулем; 
// б) в каждом столбце находится максимальный элемент и заменяется единицей
void t7()
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    int[,] table = new int[n,m];
    Console.WriteLine("table = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-80, 81);
            Console.Write("{0,5}", table[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int min = 0; int max = 0;
    int i_max = 0; int j_max = 0;
    int i_min = 0; int j_min = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        min = table[i,0]; max = table[i,0];
        i_max = i; j_max = 0;
        i_min = i; j_min = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i,j] > max)
            {
                max = table[i,j];
                i_max = i;
                j_max = j;
            }
            if (table[i,j] < min)
            {
                min = table[i,j];
                i_min = i;
                j_min = j;
            }
        }
        table[i_max,j_max] = 1;
        table[i_min,j_min] = 0;
    }
    Console.WriteLine("table NEW = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write("{0,5}", table[i,j]);
        }
        Console.WriteLine();
    }
}
t7();

// Формируется массив и выводится треугольная таблица, заполненная: а) единицами; б) нулями.
void t8()
{
    Console.Write("Введите количество строк и столбцов в таблицах : ");
    int n = int.Parse(Console.ReadLine());
    string[,] table_0 = new string[n,n];
    string[,] table_1 = new string[n,n];
    Console.WriteLine("table_0 = ");
    for (int i = 0; i < table_0.GetLength(0); i++)
    {
        for (int j = 0; j < table_0.GetLength(1); j++)
        {
            if ((n - j) > i)
            {
               table_0[i,j] = "0";
            }
            else
            {
                table_0[i,j] = " ";
            }
            Console.Write("{0,5}", table_0[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("table_1 = ");
    for (int i = 0; i < table_1.GetLength(0); i++)
    {
        for (int j = 0; j < table_1.GetLength(1); j++)
        {
            if ((i >= j))
            {
               table_1[i,j] = "1";
            }
            else
            {
                table_1[i,j] = " ";
            }
            Console.Write("{0,5}", table_1[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
t8();
