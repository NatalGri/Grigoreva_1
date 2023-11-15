/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

int[,] GenerateMatrix(int row, int col)
{
    Random rand = new Random();
    int[,] matrix = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rand.Next(-9, 10);
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

void ReverseMatrix(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

// --------------------------------------------

int[,] myMatrix = GenerateMatrix(4, 4);
PrintMatrix(myMatrix);
ReverseMatrix(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine();
PrintMatrix(myMatrix);
