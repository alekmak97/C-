// Dont work

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

Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());
int[,] table = new int[n,m];
int nn = n; 
int mm = m;



// void Fill(int row, int col, int x)
// {
//     if ((table[row,col] == 0) && (row >= 0 && row < n) && (col >= 0 && col < m))
//     {
//         table[row,col] = x;
//         x++;
//         // Правила хождения и закраски объекта внутри какой блок за чем идёт
//         try
//         {
//             Fill(row,col+1, x);
//             Fill(row+1,col, x);
//             Fill(row,col-1, x);
//             Fill(row-1,col, x);
//         }
//         catch (IndexOutOfRangeException e)
//         {}
//     }
// }



void Fill(int row, int col, int x)
{
    if (x == (nn*mm - (nn-2)*(mm-2))) 
        {
            nn = nn - 2; 
            mm = mm - 2;
            row = table.GetLength(0) - nn - 1;
            col = table.GetLength(1) - mm - 1;
            x++;
        }

    if ((table[row,col] == 0) && (row >= 0 && row < n) && (col >= 0 && col < m))
    {
        table[row,col] = x;
        try
        {
            if (row == table.GetLength(0) - nn  && col == table.GetLength(1) - mm)
            {
                while (col+1 < mm)
                {
                    Fill(row,col, x);
                    col++;
                    x++;
                }
            }
            if (row == table.GetLength(0) - nn && col == mm-1)
            {
                while (row+1 < nn)
                {
                    Fill(row,col, x);
                    row++;
                    x++;
                }
            }
            if (row == nn-1 && col == mm-1)
            {
                while (col != table.GetLength(1) - mm)
                {
                    Fill(row,col, x);
                    col--;
                    x++;
                }
            }
            if (row == nn-1 && col == table.GetLength(1) - mm)
            {
                while (row != table.GetLength(0) - nn)
                {
                    Fill(row,col, x);
                    row--;
                    x++;
                }
            }
        }
        catch (IndexOutOfRangeException e)
        {}
    }
}


Fill(0,0, 1);
Console.WriteLine();
Print(table);