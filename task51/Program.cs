// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols, int leftRange, int rightRange)
{
    var rand = new Random();
    var tempMatrix = new int[rows, cols];

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

int FindSumDiagonal(int[,] newMatrix)
{
    int sum = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += newMatrix[i, j];
            }
        }
    }
    return sum;
}

/* int FindSumDiagonal(int[,] newMatrix) // другой способ
    int sum = 0;

    for (int i = 0; i < newMatrix.GetLength(0) && i < newMatrix.GetLength(1); i++)
        sum += newMatrix[i, i];

    return sum;
} */

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

// ------------------------------------
int m = ReadInt("Введите количество строк двумерной матрицы: ");
int n = ReadInt("Введите количество столбцов двумерной матрицы: ");

int[,] matrix = GenerateMatrix(m, n, 0, 9);
PrintMatrix(matrix);
Console.WriteLine(FindSumDiagonal(matrix));
