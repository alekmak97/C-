// Инкапсуляция. Сокрытие полей, создание свойств

// Сокрытие полей, создание свойств.

/* 2. В едином пространстве имен con231 с шаблоном класса Program создадим класс Student. В этом классе объявим два поля 
fam (фамилия) и kurs (курс). Создадим конструкторы и метод ShowInfo(), который выводит информацию о студенте. */

/* Внимание! Для удобства отладки программы все поля и методы сначала
объявляем public (общедоступные). Имена полей вводим с маленькой буквы! */

class Student
{
    private string fam; // поле стало закрытым
    public string Fam // сгененрировано свойство
    {
        get { 
            return fam; 
            } // получение значения
        set {
            if (fam == "")
                {
                fam = "неизвестный";
                }
            else
                {
                fam = value.ToUpper();
                } 
            } // установка значения
    }
   private int kurs;
   public int Kurs
   {
        get { return kurs; }
        set { kurs = (value<1 || value>4) ? 0 : value; } // установка значения
    }
    public Student() { } // конструктор без параметров
    public Student(string fam, int kurs) // конструктор c параметрами
    { 
        this.Fam = fam; this.Kurs = kurs; // fam и kurs сначала с малых букв
    }
    public void ShowInfo() // метод ShowInfo
    { 
        Console.WriteLine("Студент {0} курса {1}", kurs, fam);
    }
}

/* Первоначальная общедоступность полей и методов класса Student позволяет при отладке программы в методе Main() класса Program создавать 
объекты класса Student, (т. е. описывать конкретных студентов по шаблону класса Student), а также вызывать метод ShowInfo(). */

class Program
{ 
    static void Main()
    { 
        Student st1 = new Student("Иванов", 3); st1.ShowInfo();
        Student st2 = new Student("", -7); st2.ShowInfo();
        Console.ReadKey();
    }
}