// Parse

using System.Linq;
// ; не ставим, если необходимо добавить функцию
string text = "(1,2) (2,3) (4,5) (9,7) (10,11) (12,13)"
                .Replace("(", "")
                .Replace(")", "")
                ;

Console.WriteLine(text);

var data = text.Split(" ")
               .Select(item => item.Split(','))
               .Select(e => (x : int.Parse(e[0]),y : int.Parse(e[1])))
               .Where(e => e.x % 2 == 0)
               .Select(point => (point.x * 10, point.y))
               .ToArray()
               ;

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine(data[i].Item1*10); // or x, y
}

