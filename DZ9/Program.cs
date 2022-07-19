// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void t64_66()
{
    Console.Write("Введите число M: ");
    int M = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    int min;
    int max;
    if (M < N)
    {
        min = M;
        max = N;
    }
    else
    {
        min = N;
        max = M;
    }
    int sum = 0;
    for (int i = min; i <= max; i++)
    {
        sum = sum + i;
        Console.Write("{0} ", i);
    }
    Console.WriteLine();
    Console.WriteLine(sum);
}
t64_66();

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
