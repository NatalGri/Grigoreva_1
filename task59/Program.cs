/* Задача 59: Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на пересечении которых 
расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

int[,] GenerateMatrix(int row, int col)
{
    Random rand = new Random();
    int[,] matrix = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rand.Next(10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindMinNumberIndexes(int[,] myMatrix, out int minRow, out int minCol)
{
    minRow = 0;
    minCol = 0;

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            if (myMatrix[minRow, minCol] > myMatrix[i, j])
            {
                minRow = i;
                minCol = j;
            }
        }
    }
}

int[,] DeleteRowAndColInMatrix(int[,] myMatrix, int minRow, int minCol)
{
    int[,] newMatrix = new int[myMatrix.GetLength(0) - 1, myMatrix.GetLength(1) - 1];

    for (int i = 0, x = 0; i < myMatrix.GetLength(0); i++)
    {
        if (i == minRow) continue;
        for (int j = 0, y = 0; j < myMatrix.GetLength(1); j++)
        {
            if (j == minCol) continue;
            newMatrix[x, y] = myMatrix[i, j];
            y++;
        }
        x++;
    }

    return newMatrix;
}

//через тернарный оператор:

// int[,] DeleteRowAndColInMatrix(int[,] myMatrix, int minRow, int minCol)
// {
//     int[,] newMatrix = new int[myMatrix.GetLength(0) - 1, myMatrix.GetLength(1) - 1];

//     for (int i = 0; i < newMatrix.GetLength(0); i++)
//     {
//         int x = (i >= minRow) ? i + 1 : i;
//         for (int j = 0; j < newMatrix.GetLength(1); j++)
//         {
//             int y = (j >= minCol) ? j + 1 : j;
//             newMatrix[i, j] = myMatrix[x, y];
//         }
//     }

//     return newMatrix;
// }

// --------------------------------------------

int[,] myMatrix = GenerateMatrix(5, 5);
PrintMatrix(myMatrix);

FindMinNumberIndexes(myMatrix, out int minRow, out int minCol);

int[,] newMatrix = DeleteRowAndColInMatrix(myMatrix, minRow, minCol);

System.Console.WriteLine();
PrintMatrix(newMatrix);

