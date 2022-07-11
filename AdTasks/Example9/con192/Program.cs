// Составить программу, которая подсчитывает, выводит на консоль и записывает в файл money.txt (папка Data) ежемесячный баланс. 
// Доходы вводятся еженедельно (4 раза за месяц), а количество источников расхода неизвестно (для завершения вводить три нуля).

// создаем объект класса DirectoryInfo
DirectoryInfo di = new DirectoryInfo("Data");
// если папка уже существует, удаляем ее вместе с содержимым
if (di.Exists) di.Delete(true);
// создаем новую папку Data в текущей с exe-файлом папке ( ..bin/debug/)
di.Create();
// создаем файл money.txt в папке Data (экранируем слеш)
StreamWriter sw= File.CreateText("Data\\money.txt");
int sumD = 0; // начальное значение суммы доходов за месяц
// вводим доходы за каждую из 4-х недель месяца
for (int i = 1; i < 5; i++)
{ 
    Console.Write("Введите доход за {0} неделю: ", i);
    string debit = Console.ReadLine();
    sumD += int.Parse(debit);
}
Console.WriteLine("=== Доход за месяц: " + sumD); // вывод на консоль
    sw.WriteLine("=== Доход за месяц: " + sumD); // запись в файл
Console.WriteLine();
int sumR = 0; string credit = ""; // начальное значение суммы расходов
// организуем многократный ввод расходов (пока не введено три нуля 000)
while (credit != "000")
{ 
    Console.Write("Введите расход ");
    credit = Console.ReadLine();
    sumR += int.Parse(credit);
}
Console.WriteLine("=== Суммарный расход: " + sumR); // вывод на консоль
    sw.WriteLine("=== Суммарный расход: " + sumR); // запись в файл
Console.WriteLine();
int balans = sumD - sumR; // расчет и вывод баланса
string mes = (balans >= 0) ? "хорошо" : "плохо";
Console.WriteLine("=== Баланс: {0}. Это {1}!", balans.ToString(), mes);
    sw.WriteLine("=== Баланс: {0}. Это {1}!", balans.ToString(), mes);
sw.Close(); //закрываем файл money.txt
Console.ReadKey();