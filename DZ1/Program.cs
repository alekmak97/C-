// // Lesson 1, Task 2
// Console.WriteLine("L1-T2");
// Console.Write("a = ");
// string a_s = Console.ReadLine();
// double a = Convert.ToDouble(a_s);
// Console.Write("b = ");
// string b_s = Console.ReadLine();
// double b = Convert.ToDouble(b_s);
// double max;
// if(a>b)
// {
//     max = a;
// }
// else
// {
//     max = b;
// }
// Console.Write("max = ");
// Console.WriteLine(max);
// Console.Write("End L1-T2, please press Enter");
// Console.ReadLine();

// Lesson 1, Task 4
Console.WriteLine("L1-T4");
Console.Write("Введите количество элементов массива, n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[] mass = new double[] {}; //double[] mass = { };
Array.Resize(ref mass, n);

for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент массива ");
    Console.Write(i + 1);
    Console.Write("  ");
    mass[i] = Convert.ToDouble(Console.ReadLine());
    
}
int i_max = 0;
double max_ar = mass[i_max];
while (i_max < (n-1))
{
    if(mass[i_max+1]>mass[i_max])
    {
    max_ar = mass[i_max+1];
    }
    i_max=i_max+1;
}
Console.Write("max = ");
Console.WriteLine(max_ar);
Console.Write("End L1-T4, please press Enter");
Console.ReadLine();