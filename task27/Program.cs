/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int FindSumm(int num)
{
    int summ = 0;

    while (num >= 10)
    {
        int num_count = num % 10;
        num = num / 10;
        summ = summ + num_count;
    }
    summ = summ + num;
    return summ;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int number = ReadInt("Введите число: ");
System.Console.WriteLine(FindSumm(number));