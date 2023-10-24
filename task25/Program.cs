/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Degree(int numA, int numB)
{
    int deg = numA;
    for (int i = 1; i < numB; i++)
    {
        deg *= numA; 
    }
    return deg;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
int result;

if (numberB > 0)
{
    result = Degree(numberA, numberB);
    System.Console.WriteLine(result);
}
else if (numberB == 0)
{
    result = 1;
    System.Console.WriteLine(result);
}
else
    Console.WriteLine($"Невозможное значение");
