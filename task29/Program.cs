/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int [] CreateArray(int size, int minVal, int maxVal)
{
    int [] array_new = new int[size];

    for (int i = 0; i < size; i++)
    {
        array_new[i] = new Random().Next(minVal, maxVal + 1);
    } 
    return array_new;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
}

int size = 8;
int minPosVal = 1;
int maxPosVal = 10;

int [] array = CreateArray(size, minPosVal, maxPosVal);
PrintArray(array);