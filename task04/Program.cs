/* Задача 4. Напишите программу, которая принимает на вход три числа 
и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22 */

Console.Write("Введите первое целое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

if (num_1 >= num_2 && num_1 >= num_3)
{
    System.Console.WriteLine($"max = {num_1}");
}
else if (num_1 >= num_2 && num_1 <= num_3)
{
    System.Console.WriteLine($"max = {num_3}");
}
else if (num_2 >= num_3)
{
    System.Console.WriteLine($"max = {num_2}");
}
else
{
    System.Console.WriteLine($"max = {num_3}");
} 