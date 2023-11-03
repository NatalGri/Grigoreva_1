/* Задача 62: Заполните спирально массив 4 на 4.

1   2   3   4
12  13  14  5
11  16  15  6
10  9   8   7 */

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] newMatrix = new int[rows, cols];
    int count = 1;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = count;
            count++;
            
        }
    }
    return newMatrix;
}


void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = GenerateMatrix(4, 4);
PrintMatrix(matrix);
