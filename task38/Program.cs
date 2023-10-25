/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементами массива.
[3 7 22 2 78] -> 76 */

double[] CreateArrayDouble(int sizeArray, int leftRange, int rightRange)
{
    double[] arr = new double[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, 2);
    }
    return arr;
}

void PrintArray(double[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join("\t", arrayForPrint) + "]");
}

double FindMax (double[] arrayForMax)
{
    double max = arrayForMax[0];
    
    for (int i = 1; i < arrayForMax.Length; i++)
    {
        if (max <= arrayForMax[i])
        {
            max = arrayForMax[i];
        }
    }
    return max;
}

double FindMin (double[] arrayForMin)
{
    double min = arrayForMin[0];
    
    for (int i = 1; i < arrayForMin.Length; i++)
    {
        if (min >= arrayForMin[i])
        {
            min = arrayForMin[i];
        }
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] arrayMaxMin)
{
    double diff = Math.Round(FindMax(arrayMaxMin) - FindMin(arrayMaxMin), 2);
    return diff;
}


double[] array = CreateArrayDouble(5, 1, 10);
System.Console.WriteLine("Массив:"); 
PrintArray(array);
System.Console.WriteLine($"Максимальное значение в массиве: {FindMax(array)}");
System.Console.WriteLine($"Минимальное значение в массиве: {FindMin(array)}");
System.Console.WriteLine($"Разница между максимальным и минимальным значениями в массиве: {CalcDifferenceBetweenMaxMin(array)}");
