// Пример 1. Формирование и вывод двумерного массива заданных чисел
void con141()
{
    // формируем прямоугольный массив чисел из двух строк
    int[,] ar = { { 11,12,13,14,15 }, { 21,22,23,24,25 } };
    // с помощью foreach все элементы выводятся в одну строку
    foreach (int x in ar) Console.Write("{0,4}", x);
    Console.WriteLine();
    // выводим числа построчно (в форме таблицы)
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 5; j++) Console.Write("{0,4}", ar[i,j]); // j-я строка
        Console.WriteLine(); // переход на следующую строку
    }
    Console.ReadKey();
}
con141();

// Пример 2. Формирование и вывод таблицы чисел
void con142()
{
    Console.Write("Введите количество строк (n<9): ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов (m<9): ");
    int m = int.Parse(Console.ReadLine());
    // объявляем массив чисел из n строк и m столбцов
    int[,] mas = new int[n, m];
    // построчно заполняем массив целыми числами
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++) mas[i,j] = 10*i + j; // i-я строка
    }
    // построчно выводим элементы массива (в форме таблицы)
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write("{0,4}", mas[i,j]); // вывод элементов i-й строки
        Console.WriteLine(); // переход на следующую строку
    }
    Console.ReadKey();
}
con142();

// Пример 3. Формирование и вывод ступенчатого массива чисел
void con143()
{
    // построчно объявляем и заполняем массив из 3-х одномерных массивов
    int[][] jag = new int[3][]
    { 
        new int[] {3,7,9,5,12},
        new int[] {2,4},
        new int[] {1,3,5} 
    };
    // построчно выводим три внутренних одномерных массива
    foreach (int[] arr in jag)
    { foreach (int a in arr) Console.Write("{0,4}", a);
    Console.WriteLine();
    }
    Console.ReadKey();
}
con143();
