// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void t41()
{
    Console.WriteLine("Введите количество элементов массива, M: ");
    int M = int.Parse(Console.ReadLine());
    int[] A = new int[M];
    int count = 0;
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(-99, 100);
        Console.Write("{0} ", A[i]);
        if (A[i] > 0) count++;
    }
    Console.WriteLine();
    Console.WriteLine("Количество чисел больше 0 = {0}", count);
}
t41();

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void t43()
{
    Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
    Console.WriteLine("Введите k1: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("x = (b2 -b1)/(k1 - k2), y = k2 * x + b2");
    double x = (b2 - b1) / (k1 - k2); 
    double y = k2 * x + b2;
    Console.WriteLine("x = {0:f2}, y = {1:f2}", x, y);
}
t43();
