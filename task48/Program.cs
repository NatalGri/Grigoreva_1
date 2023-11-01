/* Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
rows = 3, cols = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols, int leftRange, int rightRange)
{
    var tempMatrix = new int[rows, cols]; // var - неявно заданный тип, можно сразу писать int

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = i + j;
        }
    }

    return tempMatrix;
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

// ------------------------------------
int m = ReadInt("Введите количество строк двумерной матрицы: ");
int n = ReadInt("Введите количество столбцов двумерной матрицы: ");

int[,] matrix = GenerateMatrix(m, n, 0, 10);
PrintMatrix(matrix);
