/* Задача 5. Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
Пример:
4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4 */

Console.Write("Введите целое число: "); 
int number = Convert.ToInt32(Console.ReadLine());

int current_num = (-1) * number;

/* while (current_num <= number) // перый вариант решения
{
    System.Console.Write(current_num + ", ");
    current_num++;
} */

for (int i = current_num; i <= number; i++) // второй вариант решения
{
    System.Console.Write(i + ", ");
}