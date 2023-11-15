/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент
входных данных.

         Набор данных                            Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }                     0 встречается 2 раза
                                               1 встречается 1 раз
                                               2 встречается 1 раз
                                               8 встречается 1 раз
                                               9 встречается 3 раза

1, 2, 3                                        1 встречается 3 раза
4, 6, 1                                        2 встречается 2 раз
2, 1, 6                                        3 встречается 1 раз
                                               4 встречается 1 раз
                                               6 встречается 2 раза */


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

// первый способ:

// void PrintCountOfElements(int[,] myMatrix)
// {
//     for (int k = 0; k < 10; k++)
//     {
//         int count = 0;

//         for (int i = 0; i < myMatrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < myMatrix.GetLength(1); j++)
//             {
//                 if (myMatrix[i, j] == k) count++;
//             }
//         }

//         if (count > 0)
//             Console.WriteLine($"{k} встречается {count} раз");
//     }
// }

// второй способ:

void PrintCountOfElements2(int[,] myMatrix)
{
    int[] countElem = new int[10];

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            countElem[myMatrix[i, j]]++;
        }
    }

    for (int i = 0; i < countElem.Length; i++)
    {
        if (countElem[i] > 0)
            System.Console.WriteLine($"{i} встречается {countElem[i]} раз");
    }
}

// --------------------------------------------

int[,] myMatrix = GenerateMatrix(3, 3);
PrintMatrix(myMatrix);
//PrintCountOfElements(myMatrix);
PrintCountOfElements2(myMatrix);