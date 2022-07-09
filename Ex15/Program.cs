string[,] table = new string[2, 5];
// 00 01 02 03 04
// 10 11 12 13 14

// table[1,2] = "слово";


// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - ссылка на количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 - ссылка на количество столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - ссылка на количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 - ссылка на количество столбцов
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);