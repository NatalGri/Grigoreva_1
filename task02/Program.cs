/* Задача 2. Напишите программу, которая на вход принимает два числа
и выдает, какое число больше, а какое меньше.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3 */

Console.Write("Введите первое целое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 >= num_2)
{
    System.Console.WriteLine($"max = {num_1}");
}
else
{
    System.Console.WriteLine($"max = {num_2}");
}
