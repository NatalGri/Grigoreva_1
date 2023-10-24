// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] arrayToFill)
{
Random rand = new Random();

for (int i = 0; i < arrayToFill.Length; i++)
{
arrayToFill[i] = rand.Next(2);
}
}

void PrintArray(int[] arrayForPrint)
{
for (int i = 0; i < arrayForPrint.Length; i++)
{
System.Console.Write(arrayForPrint[i] + " ");
}
}

// -----------------------------

int[] array = new int[8];
FillArray(array);
PrintArray(array);
