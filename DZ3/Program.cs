// Lesson 3, Task 19
Console.WriteLine("L3-T19");
Console.Write("Введите число (тип - int), A = ");
string a_s = Console.ReadLine();
string Func(string A)
{
    Char[] Array = A.ToCharArray();
    int i = 0;
    int j = Array.Length - 1;
    string t = " ";
    for (; (i<Array.Length) && (j>-1); )
    {
        if (Array[i] == Array[j])
        {
            t = "Полиндром";
        }
        else
        {
            t = "Не Полиндром";
        }
        i++;
        j--;
        if (t == "Не Полиндром")
        {
            break;
        }
    }
    return t;
}
string text = Func(a_s);
Console.WriteLine(text);
Console.Write("End L2-T19, please press Enter");
Console.ReadLine();



// Lesson 3, Task 21
Console.WriteLine("L3-T21");
Console.WriteLine("Введите координаты точек A и B");
Console.Write("Введите координату X точки A = ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки A = ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки A = ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X точки B = ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B = ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B = ");
double Bz = Convert.ToDouble(Console.ReadLine());

double[] A = new double[] {Ax, Ay, Az};
double[] B = new double[] {Bx, By, Bz};

double dist(double[] AA, double[] BB)
{
    double AB = Math.Sqrt(Math.Pow((AA[0]-BB[0]), 2) + Math.Pow((AA[1]-BB[1]), 2) + Math.Pow((AA[2]-BB[2]), 2));
    return AB;
}

double D = dist(A, B);
Console.Write("Расстояние между точками А и В: ");
Console.WriteLine(D);

Console.Write("End L2-T21, please press Enter");
Console.ReadLine();


// Lesson 3, Task 23
Console.WriteLine("L3-T23");
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] N_array = {};

void Create_and_Print_array(int[] N_a, int Nn)
{
    Array.Resize(ref N_a, Nn);
    int i = 0;
    while (i < Nn)
    {
        N_a[i]=Convert.ToInt32(Math.Pow(i+1, 3));
        Console.Write(N_a[i] + " ");
        i++;    
    }    
}

Create_and_Print_array(N_array, N);

Console.WriteLine();
Console.Write("End L2-T23, please press Enter");
Console.ReadLine();