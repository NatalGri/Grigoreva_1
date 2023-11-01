/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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


double[] FindAverageInColumns(int[,] matrixNew)
{
    double[] average = new double[matrixNew.GetLength(1)];

    for (int j = 0; j < matrixNew.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrixNew.GetLength(0); i++)
        {
            sum += matrixNew[i, j];
            average[j] = Math.Round((double)sum / matrixNew.GetLength(0), 2);
        }
    }
    return average;
}

void PrintAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(string.Format("{0:0.00}", array[i]) + "\t");
    }
}


int[,] matrix = GenerateMatrix(5, 3, 0, 100);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintAverage(FindAverageInColumns(matrix));


// решение в Юни-тесте:

/* public static void PrintArray(int[,] matrix)
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

public static int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] newMatrix = new int[n, m];
    int currentValue = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            newMatrix[i, j] = currentValue;
            currentValue += k;
        }
    }
    return newMatrix;
}

static void PrintListAvr(double[] list)
{
    Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write(string.Format("{0:0.00}", list[i]) + "\t");
    }
}

static double[] FindAverageInColumns(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            average[j] = (double)sum / matrix.GetLength(0);
        }
    }
    return average;
} */




