// Напишите программу, которая на вход принимает число 
// и выдает его квадрат (число умноженное само на себя).

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqr = number * number;
// System.Console.WriteLine($"Квадрат числа: {sqr}");

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Квадрат числа: {number * number}");


// Задача 1. Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
// Например:
// а = 25, b = 5 -> да
// а = 2, b = 10 -> нет

Console.Write("Введите первое целое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_2 == num_1 * num_1)
    System.Console.WriteLine($"Число {num_2} является квадратом числа {num_1}");
else
{
    System.Console.WriteLine($"Число {num_2} не является квадратом числа {num_1}");
}