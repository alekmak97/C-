// Перегрузка методов
// Заказ номеров в гостинице. Использование перегрузки конструкторов.

class Zakaz
{
    private string fam; private int size; private string comfort;
    // создаем четыре конструктора
    public Zakaz(string fm, int sz, string cmf) // 3 параметра
    { fam = fm; size = sz; comfort = cmf; }
    public Zakaz(string fm, int sz) // 2 параметра
    { fam = fm; size = sz; comfort = "стандарт"; }
    public Zakaz(string fm) // 1-параметр
    { fam = fm; size = 3; comfort = "стандарт"; }
    public Zakaz() // без параметров
    { fam = "неизвестный"; size = 6; comfort = "общежитие"; }
    public void Show()
    { Console.WriteLine("{0} забронировал {1} местный номер класса {2}",
    fam, size, comfort); } 
}

class Program
{ 
    static void Main()
    { 
        Zakaz z1 = new Zakaz("Иванов", 1, "Люкс"); z1.Show();
        Zakaz z2 = new Zakaz("Петров", 2); z2.Show();
        Zakaz z3 = new Zakaz("Сидоров"); z3.Show();
        Zakaz z4 = new Zakaz(); z4.Show();
        Console.ReadKey(); 
    }
}