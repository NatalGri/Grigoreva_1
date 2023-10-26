/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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


int SumOddElements(int[] arraySum)
{
    int sum = 0;
    for (int i = 1; i < arraySum.Length; i+=2)
    {
        sum += arraySum[i];
    }
    return sum;
}

/* int SumOddElements(int[] arraySum) // второй способ
{
    int sum = 0;
    for (int i = 0; i < arraySum.Length; i++)
    {
        if(i % 2 !=0)
        {
            sum += arraySum[i];    
        }
    }
    return sum;
} */

int[] array = GenerateArray(5, 1, 20);
PrintArray(array);
int sumOdd = SumOddElements(array);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");

