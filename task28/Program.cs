// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int ReadIntAbs(string text)
{
System.Console.Write(text);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int MultNumbers(int N)
{
int result = 1;

for (int i = 2; i <= N; i++)
{
result *= i;
}

return result;
}
// -------------------------------

int number = ReadIntAbs("Введите число: ");
System.Console.WriteLine(MultNumbers(number));
