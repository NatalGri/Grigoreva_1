/* Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса нечётные, 
и замените эти элементы на их квадраты. */

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

void FindIndex(int[,] newMatrix)
{
    for (int i = 1; i < newMatrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < newMatrix.GetLength(1); j += 2)
            newMatrix[i, j] = (int)Math.Pow(newMatrix[i, j], 2);
    }
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

int[,] matrix = GenerateMatrix(m, n, 0, 99);
PrintMatrix(matrix);
FindIndex(matrix);
Console.WriteLine();
PrintMatrix(matrix);