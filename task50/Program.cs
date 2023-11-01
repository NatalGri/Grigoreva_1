/* Задача 50: Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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

void PrintMatrix(int[,] printMatrix)
{
    for (int i = 0; i < printMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < printMatrix.GetLength(1); j++)
        {
            System.Console.Write(printMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int FindElement(int[,] newMatrix, int x, int y)
{
    int value = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (x == i && y == j)
            {
                value = newMatrix[i, j];
            }    
        }    
    }
    return value;    
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите количество строк двумерной матрицы: ");
int n = ReadInt("Введите количество столбцов двумерной матрицы: ");
int xUs = ReadInt("Введите строку, в которой находится искомое значение: ");
int yUs = ReadInt("Введите столбец, в котором находится искомое значение: ");

int[,] matrix = GenerateMatrix(m, n, 0, 10);
PrintMatrix(matrix);
System.Console.WriteLine();

if (xUs < n && yUs < m)
    System.Console.WriteLine($"Значение искомого элемента на позиции [{xUs};{yUs}] = {FindElement(matrix, xUs, yUs)}");
else
    System.Console.WriteLine("Такого числа в массиве нет");


// решение для юни-тестов:

/* void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    Random rand = new Random();
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 98) + k;
        }
    }
    return matrix;
}


int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int[] result = new int[2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == rowPosition && j == columnPosition)
            {
                result[0] = matrix[i, j];
                result[1] = 0;    
            }
            else if (rowPosition >= matrix.GetLength(0) && columnPosition >= matrix.GetLength(1))
            {
                result[1] = 0;    
            }
        }
    }
    return result;
}


void PrintCheckIfError(int[] result, int X, int Y)
{
  if (results[0] == 0 && results[1] == 0)
    {
        System.Console.WriteLine("There is no such index");
    }
    else
        System.Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");  
}


int[,] matrix = CreateIncreasingMatrix(3, 4, 2);
PrintArray(matrix);
System.Console.WriteLine();

int[] res = FindNumberByPosition(matrix, 2, 1);
PrintCheckIfError(res, 2, 1);
 */