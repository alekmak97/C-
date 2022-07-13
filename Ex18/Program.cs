// using System.Linq;

// int a = 12;
// Console.WriteLine(a.GetType());
// Console.WriteLine(a.GetType().Name);

// string mes = (string)a.GetType().Name;
// Console.WriteLine(mes);

// var b = 12;
// Console.WriteLine(b.GetType().Name);

// var data = new int[] {1,2,3,4}
//         .Where(e => e > 0)
//         .Select(e => new { q = e, w = e + 1});
// Console.WriteLine(data.GetType());



// enum

Console.WriteLine(DayOfWeek.Monday);
int day = (int)DayOfWeek.Sunday;
Console.WriteLine(day);
Console.WriteLine();
Console.WriteLine();


enum DayOfWeek
{
    Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
}
