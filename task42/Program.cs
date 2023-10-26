/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowBinary(int num) // деление на 2, потому что перевод в двоичное представление
{
    if(num == 0) return;
    ShowBinary(num / 2);
    System.Console.Write(num % 2);
}


int number = ReadInt("Введите число: ");
ShowBinary(number);

// System.Console.WriteLine(Convert.ToString(number, 2)); // способ без рекурсии
