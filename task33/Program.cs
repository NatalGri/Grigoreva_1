// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да


using System.Reflection.Metadata;

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

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool FindElement(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == element) return true;

    return false;
}

// -------------------------------

int[] array = GenerateArray(5, -9, 9);
PrintArray(array);

int number = ReadInt("Введите искомое число: ");

if (FindElement(array, number))
{
    System.Console.WriteLine("Нашли число!");
}
else
{
    System.Console.WriteLine("Число не было найдено!");
}



// второй способ, когда нужно его узнать количество искомого числа в массиве
using System.Reflection.Metadata;

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

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

bool FindElement(int[] array, int element, out int count)
{
count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] == element) count++;

if(count!= 0) return true;

return false;
}

// -------------------------------

int[] array = GenerateArray(10, 0, 5);
PrintArray(array);

int number = ReadInt("Введите искомое число: ");

if (FindElement(array, number, out int count))
{
System.Console.WriteLine("Нашли число! \nИх количество: " + count);
}
else
{
System.Console.WriteLine("Число не было найдено!");
}