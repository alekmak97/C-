
// Создание массива
void FillArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i,j] = new Random().Next(-100,101);
        }
    }

}

void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write("{0,6}", ar[i,j]);
        }
        Console.WriteLine();
    }
}

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void t54()
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    int[,] table = new int[n,m];
    Console.WriteLine("table = ");    
    FillArray(table);
    PrintArray(table);
    Console.WriteLine();
    // min to max
    for (int i = 0; i < table.GetLength(0); i++)
    {
       for (int k = 0; k < table.GetLength(1)-1; k++)
       {
            int minPosition = k;
            for (int j = k+1; j < table.GetLength(1); j++)
            {
                if (table[i,j] < table[i,minPosition]) minPosition = j;
            }
            int temporary = table[i,k];
            table[i,k] =table[i,minPosition];
            table[i,minPosition] = temporary;
       }
    }
    PrintArray(table);
    Console.WriteLine();
    // max to min
    for (int i = 0; i < table.GetLength(0); i++)
    {
       for (int k = 0; k < table.GetLength(1)-1; k++)
       {
            int maxPosition = k;
            for (int j = k+1; j < table.GetLength(1); j++)
            {
                if (table[i,j] > table[i,maxPosition]) maxPosition = j;
            }
            int temporary = table[i,k];
            table[i,k] =table[i,maxPosition];
            table[i,maxPosition] = temporary;
       }
    }
    PrintArray(table);
}
t54();

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void t56()
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    int[,] table = new int[n,m];
    int[] sum = new int[n];
    int min_sum = 0;
    int i_min = 0;
    Console.WriteLine("table = ");    
    FillArray(table);
    PrintArray(table);
    Console.WriteLine();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum[i] = sum[i] + table[i,j];
        }
        if (i == 0) 
        {
            min_sum = sum[i];
            i_min = i;
        }
        Console.WriteLine("{0} строка, Sum = {1}", i+1, sum[i]);
        if (sum[i] < min_sum) 
        {
            min_sum = sum[i];
            i_min = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine("MIN: {0} строка, Sum = {1}", i_min+1, min_sum);
}
t56();

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void t58()
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    int[,] table = new int[n,m];
    int[,] table1 = new int[n,m];
    int[,] table2 = new int[n,m];    
    FillArray(table1);
    //PrintArray(table1);
    Console.WriteLine();
    FillArray(table2);
    // PrintArray(table2);
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            table[i,j] = table1[i,j] * table2[i,j];
        }
    }
    PrintArray(table);
}
t58();

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void t60()
{
    Console.Write("Введите высоту: ");
    int y = int.Parse(Console.ReadLine());
    Console.Write("Введите ширину: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите глубину: ");
    int z = int.Parse(Console.ReadLine());
    int[,,] table = new int[y,x,z];
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                table[i,j,k] = new Random().Next(0,10);
                Console.Write("table[{0},{1},{2}] = {3};  ", i, j, k, table[i,j,k]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
t60();

