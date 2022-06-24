// Lesson 1, Task 2
Console.WriteLine("L1-T2");
Console.Write("a = ");
string a_s = Console.ReadLine();
double a = Convert.ToDouble(a_s);
Console.Write("b = ");
string b_s = Console.ReadLine();
double b = Convert.ToDouble(b_s);
double max;
if(a>b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("End L1-T2, please press Enter");
Console.ReadLine();

// Lesson 1, Task 4
Console.WriteLine("L1-T4");
Console.Write("Введите количество элементов массива, n = ");
int n = Convert.ToInt32(Console.ReadLine()); // Конвертация из string в int
double[] mass = new double[] {}; //double[] mass = { }; // Создание пустого массива на основе типов данных double
Array.Resize(ref mass, n); // Изменение размера массива согласно введённым данным
for (int i = 0; i < n; i++) // Цикл для ввода элементов массива
{
    Console.Write("Введите элемент массива ");
    Console.Write(i + 1);
    Console.Write("  ");
    mass[i] = Convert.ToDouble(Console.ReadLine()); // Конвертация из string в double
    
}
int i_max = 0;
double max_ar = mass[i_max];
while (i_max < n) // Поиск максимального значения в массиве (первая итерация избыточна)
{
    if(mass[i_max] > max_ar)
    {
    max_ar = mass[i_max];
    }
    i_max=i_max+1;
}
Console.Write("max = ");
Console.WriteLine(max_ar);
Console.Write("End L1-T4, please press Enter");
Console.ReadLine();

// Lesson 1, Task 6
Console.WriteLine("L1-T6");
Console.Write("Введите число для проверки чётности, f = ");
double f = Convert.ToDouble(Console.ReadLine()); // Конвертация из string в double
double fz = f % 2.0; // Запись остатка
if(fz > 0 ) // Условие вывода заключения
{
    Console.WriteLine("f - нечётное число");
}
else
{
    Console.WriteLine("f - чётное число");
}
Console.Write("End L1-T6, please press Enter");
Console.ReadLine();

// // Lesson 1, Task 8
Console.WriteLine("L1-T8");
Console.Write("Введите число для вывода чётных чисел от 1 до |z|, Z = ");
double[] Z_array = new double[] {}; // Создание пустого массива на основе типов данных double
int Z = Convert.ToInt32(Math.Floor(Math.Abs(Convert.ToDouble(Console.ReadLine())))); // 1. Конвертация из string в double 2. Модуль значения 3. Округлениев меньшую сторону 4. Конвертация в int
int Za = 0;
if((Z % 2) > 0 ) // Поиск конечного чётного значения массива
{
    Za = Z-1;
}
else
{
    Za = Z;
}
int N_array = Za/2; // Определение количества элементов массива
Array.Resize(ref Z_array, N_array); // Изменение размера массива согласно введённым данным
int i_Zar = 0; //Номер элемента массива
int Zb = 0; // Число, которое должно достигнуть значения Za, чтобы элементы массива следовали в порядке увеличения значения
while (i_Zar < N_array) // Цикл записи чётных значений согласно условию в массив
{
    Z_array[i_Zar] = Zb + 2;
    Zb = Zb + 2;
    Console.Write(Z_array[i_Zar] + " ");
    i_Zar++;
}
Console.WriteLine("End L1-T8, please press Enter");
Console.ReadLine();