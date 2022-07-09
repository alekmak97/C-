// Вычисление факториала с помощью рекурсии

double Factorial(int n) // int
{
    // 1! = 1
    // 0! = 1
    if (n==1) return 1;
    else return n * Factorial(n-1);
}
// Console.WriteLine(Factorial(3));

// for (int i = 1; i < 40; i++) // обратить внимание на тип данных, иначе может быть переполнение
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Число фибоначчи

// f(1)=1
// f(2)=1
// f(n)= f(n-1) + f(n-2)....

double Fibonacci(int n)
{
    if (n== 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

