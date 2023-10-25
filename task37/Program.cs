// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


using System.Linq.Expressions;

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

int[] MultArrayElements(int[] array)
{
// int[] newArray = new int[array.Length / 2 + array.Length % 2];
int[] newArray = new int[(array.Length + 1) / 2]; // выделили память под новый массив

for(int i = 0; i < array.Length / 2; i++)
{
newArray[i] = array[i] * array[array.Length - 1 - i];
}

if(array.Length % 2 == 1)
newArray[newArray.Length - 1] = array[array.Length / 2];

return newArray;
}

// -------------------------------

int[] array = GenerateArray(9, 0, 5);
PrintArray(array);

PrintArray(MultArrayElements(array));
