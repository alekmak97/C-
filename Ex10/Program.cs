int[] array = {11, 21, 45, 12, 54, 79, 90, 123, 32};

int n = array.Length; // Длина массива
int find = 90;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // Прерывание, будет показан первый индекс, если числа в массиве совпадают
    }
    index++;
}