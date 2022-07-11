// Обработка исключений

// Обнаружение и обработка ошибка деления на 0.
void con151()
{
    Console.Write("Введите делимое ");
    int a = int.Parse(Console.ReadLine()); // при типе double выходит - ?
    Console.Write("Введите делитель ");
    int b = int.Parse(Console.ReadLine());
    // в проверяемый блок включим операцию деления и вывод результата
    try { Console.WriteLine(a / b); }
    // обработка ошибки деления на 0 и вывод системного сообщения
    catch (DivideByZeroException e)
    { Console.WriteLine(e.Message); }
    // обработка неопознанной ошибки, вывод собственного сообщения
    catch { Console.WriteLine("Произошла ошибка"); }
    Console.ReadKey();
}
con151();

// Задан строковый массив дней недели. Составим программу, которая по введенному номеру выводит название дня недели и количество дней до Вс,
// а также обрабатывает ошибки формата ввода и выхода индекса за границы массива.
void con152()
{
    // создадим массив дней недели
    string[] dw = { "Вс", "Пн", "Вт", "Ср", "Чт", "Пт", "Сб" };
    Console.Write("Введите номер дня недели (0 - 6) ");
    // в проверяемый блок включим ввод номера и вывод сообщения
    try 
    {
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}, до Вс {1} дней", dw[i], 6-i);
    }
    // обработка ошибки выхода индекса за границы диапазона
    catch (IndexOutOfRangeException e)
    { Console.WriteLine(e.Message); }
    // обработка ошибки формата ввода
    catch (FormatException e)
    { Console.WriteLine(e.Message); }
    // обработка неопознанной ошибки
    catch { Console.WriteLine("Ошибка"); }
    Console.ReadKey();
}
con152();

// Составим программу, в которой обрабатывается ошибка переполнения.
void con153()
{
    // в проверяемый блок try включим вычисление и вывод;
    // проверяемое выражение заключим в checked
    int a = 1000; int b = 3000;
    try {
        int pro = checked (a*a*b);
        Console.WriteLine("Произведение = {0}", pro);
        }
    // обработка ошибки переполнения
    catch(OverflowException e)
    { Console.WriteLine(e.Message); }
    // обработка неопознанной ошибки
    catch { Console.WriteLine("Ошибка"); }
    Console.ReadKey();
}
con153();
