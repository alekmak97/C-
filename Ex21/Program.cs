// Сумма чисел от 1 до n
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55

// Факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if (n == 1 || n== 0) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800

// Вычислить а^n
int PowerFor(int a, int n)
{ 
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n)
{ 
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024

