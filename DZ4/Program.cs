// Lesson 4, Task 25
Console.WriteLine("L4-T25");

double F()
{
   Console.Write("Введите число a = ");
   double a = Convert.ToDouble(Console.ReadLine());
   Console.Write("Введите число b = ");
   double b = Convert.ToDouble(Console.ReadLine());
   double C = Math.Pow(a, b);
   return C;
}

string V = string.Empty;
double C = 0;

while (V != "!")
{
    C = F();
    Console.WriteLine($"a ^ b = {C}");
    Console.WriteLine("Нажмите Enter для продолжение вычислений, для прекращения вычислений приравняйте V = !");
    Console.Write("V = ");
    V = Console.ReadLine();
}

Console.Write("End L4-T25, please press Enter");
Console.ReadLine();


// Lesson 4, Task 27
Console.WriteLine("L4-T27");

Console.WriteLine("Введите число: ");
string S = Console.ReadLine();

int Func(string S)
{
    int result = 0;
    for (int i = 0; i < S.Length; i++)
    {
        int temporary = (int)char.GetNumericValue(S[i]);
        result = result + temporary;
    }
    return result;
}

int Sum = Func(S);
Console.WriteLine($"Sum = {Sum}");

Console.Write("End L4-T27, please press Enter");
Console.ReadLine();


// Lesson 4, Task 29
Console.WriteLine("L4-T29");

void Array()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
        Console.WriteLine($"array[{i}] = {array[i]}; ");
    }
}

Array();

Console.Write("End L4-T29, please press Enter");
Console.ReadLine();


