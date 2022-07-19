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
// t64_66();

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
void t68()
{
    Console.Write("Введите число m: ");
    ulong m = ulong.Parse(Console.ReadLine());
    Console.Write("Введите число n: ");
    ulong n = ulong.Parse(Console.ReadLine());
    ulong A(ulong m, ulong n)
    {
        if (m == 0) return n + 1;
        else if ((m > 0) && (n == 0)) return A(m - 1, 1);
        else return A(m-1, A(m, n-1));
    }
    Console.WriteLine(A(m,n));
}
t68();