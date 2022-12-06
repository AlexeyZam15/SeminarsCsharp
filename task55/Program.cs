// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            // TODO: вывести индексы массива.
            // matrix[i, j] = i * 10 + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}{separatorElems}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(endRow);
    }
}

// int[,] ReplaceRowsColumnsMatrix(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     int[,] matrix2 = new int[columns,rows];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix2[j,i] = matrix[i,j];
//         }
//     }
//     return matrix2;
// }

bool CheckSquareMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

void ReplaceRowsColumnsMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows-1; i++)
    {
        for (int j = i+1; j < columns; j++)
        {
           int temp = matrix[i,j];
           matrix[i,j] = matrix[j,i];
           matrix[j,i] = temp;
        }
    }
}

int[,] matrix1 = CreateMatrixRndInt(3,4,1,9);
PrintMatrix(matrix1, "","","");
Console.WriteLine();
// matrix1 = ReplaceRowsColumnsMatrix(matrix1);
if (CheckSquareMatrix(matrix1) == false)
Console.WriteLine("Это невозможно");
else
{
ReplaceRowsColumnsMatrix(matrix1);
PrintMatrix(matrix1, "","","");
}
