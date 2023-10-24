// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// _тип_данных_ _название_функции_ (_принимаемые_параметры_)
// {
// _тело_функции_
// }


int SumNumbers(int A)
{
int sum = 0;

for(int i = 1; i <= A; i++)
{
sum += i;
}

return sum;
}


int ReadInt(string text)
{
System.Console.Write(text);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

// -----------------------------------------------

int number = ReadInt("Введите число: ");
System.Console.WriteLine(SumNumbers(number));
