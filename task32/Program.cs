// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GenerateArray(int sizeArray, int leftRange, int rightRange) // int, string, double, double[]
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return newArray;
}

void PrintArray(int[] arrayForPrint) // void
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}

// -------------------------------

int[] array = GenerateArray(5, -9, 9);
PrintArray(array);

ChangeArray(array);
PrintArray(array);
