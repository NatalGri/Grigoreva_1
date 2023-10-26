/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

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
    System.Console.WriteLine("[" + string.Join("\t", arrayForPrint) + "]");
}

int CountEvenElements(int[] arrayCount)
{
    int count = 0;
    for (int i = 0; i < arrayCount.Length; i++)
    {
        if (arrayCount[i] % 2 == 0)
        {
            count++;
        }  
    }
    return count;  
}


int[] array = GenerateArray(5, 100, 999);
Console.WriteLine("Массив:");
PrintArray(array);
int evenCount = CountEvenElements(array);
Console.WriteLine($"Количество четных элементов: {evenCount}");
