// Заполните спирально массив 4 на 4.
/* 
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
void Print(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write("{0,6}", ar[i,j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер двумерного массива (NxN), N =  ");
int n = int.Parse(Console.ReadLine());
int[,] table = new int[n,n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= table.GetLength(0) * table.GetLength(1))
{
  table[i,j] = temp;
  temp++;
  if (i <= j + 1 && i + j < table.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= table.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > table.GetLength(1) - 1)
    j--;
  else 
    i--;
}

Console.WriteLine();
Print(table);