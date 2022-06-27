// // Lesson 3, Task 19
// Console.WriteLine("L3-T19");
// Console.Write("Веедите число (тип - int), A = ");
// string a_s = Console.ReadLine();
// string Func(string A)
// {
//     Char[] Array = A.ToCharArray();
//     int i = 0;
//     int j = Array.Length - 1;
//     string t = " ";
//     for (; (i<Array.Length) && (j>-1); )
//     {
//         if (Array[i] == Array[j])
//         {
//             t = "Полиндром";
//         }
//         else
//         {
//             t = "Не Полиндром";
//         }
//         i++;
//         j--;
//         if (t == "Не Полиндром")
//         {
//             break;
//         }
//     }
//     return t;
// }
// string text = Func(a_s);
// Console.WriteLine(text);
// Console.Write("End L2-T19, please press Enter");
// Console.ReadLine();



// Lesson 3, Task 21
Console.WriteLine("L3-T21");
//Console.WriteLine("Веедите координаты точек A и B");
//Console.Write("Введите координату X точки A = ");
double Ax = 3; //Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите координату Y точки A = ");
double Ay = 45; //Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите координату Z точки A = ");
double Az = 34; //Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите координату X точки B = ");
double Bx = 45; //Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите координату Y точки B = ");
double By = 56; //Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите координату Z точки B = ");
double Bz = 456; //Convert.ToDouble(Console.ReadLine());

double[] A = new double[] {Ax, Ay, Az};
double[] B = new double[] {Bx, By, Bz};

double dist(double[] AA, double[] BB)
{
    double AB = Math.Sqrt((Math.Pow(AA[0], 2) - Math.Pow(BB[0], 2)) + (Math.Pow(AA[1], 2) - Math.Pow(BB[1], 2)) + (Math.Pow(AA[2], 2) - Math.Pow(BB[2], 2)));
    return AB;
}

double D = dist(A, B);
Console.Write("Расстояние между точками А и В: ");
Console.WriteLine(D);

Console.Write("End L2-T21, please press Enter");
Console.ReadLine();