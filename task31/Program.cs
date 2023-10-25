// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// в идеале решать через две функции: одна считает положительные, другая отрицательные

int[] GenerateArray(int sizeArray, int leftRange, int rightRange)
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return newArray;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
}

/* void PrintArray2(int[] arrayForPrint) // вывод с помощью join - с нужными разделителями
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
} */

int[] SumsOfNegativeAndPositive(int[] array)
{
    int[] sumsNumbers = new int[2];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumsNumbers[0] += array[i];
        else
            sumsNumbers[1] += array[i];
    }

    return sumsNumbers;
}
// -------------------------------

int[] array = GenerateArray(10, -9, 9);
PrintArray(array);

int[] result = SumsOfNegativeAndPositive(array);

System.Console.WriteLine($"\nСумма положительных: {result[0]} \nСумма отрицательных: {result[1]}");


/* int[] GenerateArray(int sizeArray, int leftRange, int rightRange) // другой способ
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return newArray;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
}

void SumsOfNegativeAndPositive(int[] array, out int sumPositive, out int sumNegative)
{
    sumNegative = 0;
    sumPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }
}

// -------------------------------

int[] array = GenerateArray(5, -9, 9);
PrintArray(array);

SumsOfNegativeAndPositive(array, out int sumP, out int sumN);

System.Console.WriteLine($"\nСумма положительных: {sumP} \nСумма отрицательных: {sumN}"); */