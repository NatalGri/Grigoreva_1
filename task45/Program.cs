/* Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования. */

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] Copy(int[] oldArray)
{
    int[] newArray = new int[oldArray.Length];

    for (int i = 0; i < oldArray.Length; i++)
        newArray[i] = oldArray[i];

    return newArray;
}

// -----------------------
int[] myArray = GenerateArray(10, -5, 5);
PrintArray(myArray);
int[] copyArray = Copy(myArray);
PrintArray(copyArray);

/* int[] secondCopy = myArray[..]; 

// [..] - диапазон индексов, значения которых нужно скопировать
// можно записать еще: [1..] [..10] [3..7]

// если записать без диапазона (int[] secondCopy = myArray;), то копируется ссылка на значения, а не сами значения
