// Перегрузка методов
// Использование перегрузки методов. Вычисление периметров разных фигур.

class Program
{
    static void Perim(int a, int b) // два параметра
    { 
        Console.WriteLine("Периметр прямоугольника = {0}", 2*a+2*b);
    }
    static void Perim(int a, int b, int d ) // три параметра
    { 
        Console.WriteLine("Периметр треугольника = {0}", a+b+d);
    }
    static void Perim(params int[] ar) // переменное число параметров
    { 
        int p = 0; foreach (int x in ar) p += x;
        Console.WriteLine("Периметр {0}‐угольника = {1}", ar.Length, p);
    }
    static void Main()
    { 
        Perim(10,20); Perim(3,4,5); Perim(2,3,4,5,6,7,9);
        Console.ReadKey();
    }
}
