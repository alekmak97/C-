// Использование методов класса StringBuilder.

    using System;
    using System.Text; // подключение пространства имен System.Text
    class Program
    {
        static void Main()
        {
            Console.Write("Введите зарплату: ");
            double zar = double.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder(); // создание объекта
            str.Append("зарплата ");
            // добавляем строку в денежном формате (тыс и млн отделяются)
            str.AppendFormat("{0,6:C} - за год {1,6:C}", zar, zar*12);
            Console.WriteLine(str); // вывод
            str.Replace("р.", "$."); // замена р. на $
            Console.WriteLine("А было бы лучше: " + str); // вывод
            Console.ReadKey();
        }
    }