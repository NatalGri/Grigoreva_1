// Задача 26: Напишите программу, которая принимает на вход число и
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadIntAbs(string text)
{
System.Console.Write(text);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int LenNumber(int value)
{
int len = 0;

while (value > 0)
{
value /= 10;
len++;
}

return len;
}

// -------------------------------

int number = ReadIntAbs("Введите число: ");

Console.WriteLine(LenNumber(number));
