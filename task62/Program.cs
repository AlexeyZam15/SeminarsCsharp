// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixIncIntSpiral(int rows, int columns, int startNumber)
{
    int[,] matrix = new int[rows, columns];
    int direction = 0;
    int size = rows * columns;
    int indexi = 0;
    int indexj = 0;
    int directionLength = columns;
    while (startNumber <= size)
    {
        for (int j = 0; j < directionLength; j++)
        {
            // Console.WriteLine($"{direction} {directionLength} {indexi} {indexj} {startNumber + 1}");
            if (direction == 0)
            {
                matrix[indexi, indexj++] = startNumber++;
            }
            else if (direction == 1)
            {
                matrix[indexi++, indexj] = startNumber++;
            }
            else if (direction == 2)
            {
                matrix[indexi, indexj--] = startNumber++;
            }
            else if (direction == 3)
                matrix[indexi--, indexj] = startNumber++;
        }
        if (direction == 0)
        {
            rows--;
            directionLength = rows;
            indexj--;
            indexi++;
            direction = 1;
        }
        else if (direction == 1)
        {
            columns--;
            directionLength = columns;
            direction = 2;
            indexi--;
            indexj--;
        }
        else if (direction == 2)
        {
            rows--;
            directionLength = rows;
            direction = 3;
            indexj++;
            indexi--;
        }
        else if (direction == 3)
        {
            columns--;
            directionLength = columns;
            direction = 0;
            indexi++;
            indexj++;
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
                Console.Write($"{matrix[i, j],3}{separatorElems}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(endRow);
    }
}

int[,] matrix1 = CreateMatrixIncIntSpiral(4, 4, 1);
PrintMatrix(matrix1, "", "", "");