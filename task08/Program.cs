/* Задача 8. Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все четные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

System.Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{number} -> ");

for (int i = 2; i <= number; i+=2)
{
    System.Console.Write(i + ", ");
}
System.Console.Write("\b\b ");