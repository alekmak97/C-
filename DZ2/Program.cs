// // Lesson 2, Task 10
// Console.WriteLine("L2-T10");
// Console.Write("Please write number (type - int), A = ");
// string a_s = Console.ReadLine();
// Char[] array1 = a_s.ToCharArray();
// Console.Write("Вторая цифра числа: ");
// Console.WriteLine(array1[1]);
// Console.Write("End L2-T10, please press Enter");
// Console.ReadLine();

// // Lesson 2, Task 13
// Console.WriteLine("L2-T13");
// Console.Write("Please write number (type - int), A = ");
// string aa_s = Console.ReadLine();
// Char[] array2 = aa_s.ToCharArray();
// if (array2.Length < 3)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     Console.Write("Третья цифра числа: ");
//     Console.WriteLine(array2[2]);
// }
// Console.Write("End L2-T13, please press Enter");
// Console.ReadLine();

// Lesson 2, Task 15
Console.WriteLine("L2-T15");
Console.Write("День недели = ");
string Day_s = Console.ReadLine();
int Day = Convert.ToInt16(Day_s);
if ((Day < 6) && (Day > 0))
{
    Console.WriteLine("Рабочий день");
}
else if ((Day > 5) && (Day <8))
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Ошибка");
}
Console.Write("End L2-T15, please press Enter");
Console.ReadLine();