// Задайте двумерный массив размером n×m, заполненный случайными вещественными числами
void t47()
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    double[,] table = new double[n,m];
    Console.WriteLine("table = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = Convert.ToDouble(new Random().Next(-1000,1001))/100;
            Console.Write("{0,6}", table[i,j]);
        }
        Console.WriteLine();
    }
}
t47();

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
void t50()
{
    Console.Write("i: ");
    int i_n = int.Parse(Console.ReadLine());
    Console.Write("j_n: ");
    int j_n = int.Parse(Console.ReadLine());
    int[,] table = new int[10,10];
    Console.WriteLine("table = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-99,100);
            Console.Write("{0,4}", table[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    if (i_n < table.GetLength(0) && j_n < table.GetLength(1))
    {
        Console.WriteLine("{0}", table[i_n,j_n]);
    }
    else
    {
        Console.WriteLine("Числа нет");
    }
}
t50();

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void t52()
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    int[,] table = new int[n,m];
    double sum = 0;
    double A = 0;
    Console.WriteLine("table = ");
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-90,91);
            Console.Write("{0,4}", table[i,j]);
        }
        Console.WriteLine();
    }
    for (int j = 0; j < table.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < table.GetLength(0); i++)
        {
            sum = sum + table[i,j];
        }
        A = sum / n;
        Console.WriteLine("Столбец {0}, A = {1:f2}", j+1, A);
    }

}
t52();