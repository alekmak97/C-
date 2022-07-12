// Создание класса и объекта. Создание и вызов метода. Конструкторы.

// 2. В едином пространстве имен namespace con211 с шаблоном класса Program создадим класс Build (проект строения). По умолчанию он имеет модификатор доступа internal.
// 3. В этом классе объявим три поля name (имя), area (площадь), kvo (количество жильцов) с модификаторами доступа public. 
// Создадим метод ShowInfo(), который вычисляет площадь на одного жильца и выводит информацию о строении.

// 6. Модифицируем программу. Создадим в классе Build собственный конструктор с тремя параметрами (nm, ar, k). 
// Конструктор по умолчанию (без параметров) теперь тоже необходимо записать в явном виде.


class Build
{ 
    /*здесь мои свойства и поля*/
    public string name; 
    public double area; 
    public int kvo; // OLD

    /*тут мои методы*/
    // Build() { } // конструктор без параметров (new)
    public Build (string name, double area, int kvo) // конструктор c параметрами (new)
    { this.name = name; this.area = area; this.kvo = kvo; }
    
    public void ShowInfo()
    { 
        Console.WriteLine("В доме {0} площадью {1} кв.м. живет {2} чел, на человека {3:f2} кв.м.", name, area, kvo, area/kvo);
    }
}

// 4. В методе Main() класса Program создадим объект dom1 класса Build, (т. е. построим дом по проекту Build), используя конструктор по умолчанию (без параметров). 
// Зададим значения полей (параметры нашего дома). Вызовем метод ShowInfo().
// class Program // В консольной программе только один класс Program и обязательно объявление static void Main
// {     
//     static void Main()
//     { 
//         // OLD
//         // Build dom1 = new Build(); // создание объекта dom1
//         // dom1.name="Дача"; dom1.area=30; dom1.kvo=4; // инициализация
//         // dom1.ShowInfo(); // вызов метода
//         Build dom2 = new Build("Коттедж", 80, 6);
//         dom2.ShowInfo();
//         Program.My();
//         Console.ReadKey();
//     }
//     public static void My()
//     {
//         int a = Program.Func();
//         Console.WriteLine(a);
//     }
//     public static int Func()
//     {
//         int result = new Random().Next(-10, 11);
//         return result;
//     }
// }


/* NEW */
class Program // В консольной программе только один класс Program и обязательно объявление static void Main
{     
    static void Main()
    { 
        Build dom = Program.NewDom();
        dom.ShowInfo();
        Program.My();
        Console.ReadKey();
    }
    public static void My()
    {
        int a = Program.Func();
        Console.WriteLine("Random = {0}", a);
        
    }
    public static int Func()
    {
        int result = new Random().Next(-10, 11);
        return result;
    }
    public static Build NewDom() // можно вынести в отдельный класс
    {
        Build dom2 = new Build("Коттедж", 80, 6);
        return dom2;
    }
}