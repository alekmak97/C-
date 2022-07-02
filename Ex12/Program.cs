// Methods

// Вид 1. Ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine("Author ...");
}
Method1();


// Вид 2. Ничего не возвращает, но принимает
void Method2(string msg, int arg)
{
    int i = 0;
    while (i <arg)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2(msg: "Text", arg: 3);


// Вид 3. Что-то возвращает, но не принимает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);



// Вид 4. Что-то возвращает, что-то принимает
string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i= 0; i<count; i++)
    {
        result = result +c;
    }
    return result;
}
string res = Method4(10, "qwe");
Console.WriteLine(res);


for (int i= 2; i<=10; i++)
{
    for (int j= 2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}