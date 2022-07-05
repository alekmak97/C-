// Lesson 5, Task 34
Console.WriteLine("L5-T34");

Console.Write("Введите размер массива, N = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] A = new int[] {};
Array.Resize(ref A, N);

void FillArray1(int[] Ar)
{
    int i = 0;
    while (i < Ar.Length)
    {
        Ar[i] = new Random().Next(100, 1000);
        i++;
    }
    for (int j = 0; j < Ar.Length; j++)
    {
       Console.Write($"A[{j}] = {Ar[j]}; ");
    }
    Console.WriteLine(); 
}

void NumFillArray1(int[] Arr)
{
    int Count = 0;
    int index = 0;
    while (index < Arr.Length)
    {        
        if ((Arr[index]%2) == 0)
        {
            Count = Count + 1;
        }
        index++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве = {Count}");
}

FillArray1(A);
NumFillArray1(A);

Console.Write("End L5-T34, please press Enter");
Console.ReadLine();


// Lesson 5, Task 36
Console.WriteLine("L5-T36");

Console.Write("Введите размер массива, N = ");
int Nn = Convert.ToInt32(Console.ReadLine());
int[] An = new int[] {};
Array.Resize(ref An, Nn);

void FillArray2(int[] Arn)
{
    int i1 = 0;
    while (i1 < Arn.Length)
    {
        Arn[i1] = new Random().Next(-30000, 30001);
        i1++;
    }
    for (int j1 = 0; j1 < Arn.Length; j1++)
    {
       Console.Write($"A[{j1}] = {Arn[j1]}; ");
    }
    Console.WriteLine(); 
}

void NumFillArray2(int[] Arrn)
{
    int Sum = 0;
    int indexn = 0;
    while (indexn < Arrn.Length)
    {        
        if ((indexn%2) == 1)
        {
            Sum = Sum + Arrn[indexn];
        }
        indexn++;
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {Sum}");
}

FillArray2(An);
NumFillArray2(An);

Console.Write("End L5-T36, please press Enter");
Console.ReadLine();


// Lesson 5, Task 38
Console.WriteLine("L5-T38");

Console.Write("Введите размер массива, N = ");
int Nm = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[] {};
Array.Resize(ref mass, Nm);

void FillArray3(int[] m)
{
    for (int i = 0; i < m.Length; i++)
    {
        m[i] = new Random().Next(-30000, 30001);
    }
    for (int j = 0; j < m.Length; j++)
    {
       Console.Write($"mass[{j}] = {m[j]}; ");
    }
    Console.WriteLine(); 
}

int Max_array(int[] mx)
{
    int max = mx[0];
    for (int i = 0; i < mx.Length; i++)
    {
        if (mx[i] > max)
        {
            max = mx[i];
        }
    }
    return max;
}

int Min_array(int[] mn)
{
    int min = mn[0];
    for (int i = 0; i < mn.Length; i++)
    {
        if (mn[i] < min)
        {
            min = mn[i];
        }
    }
    return min;
}

FillArray3(mass);
int Max = Max_array(mass);
int Min = Min_array(mass);

int dif = Max - Min;

Console.WriteLine("Значения массива");
Console.WriteLine($"Max = {Max}");
Console.WriteLine($"Min = {Min}");
Console.WriteLine($"Max - Min = {dif}");

Console.Write("End L5-T38, please press Enter");
Console.ReadLine();