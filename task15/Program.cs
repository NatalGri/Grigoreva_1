/* Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

System.Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5)
{
    System.Console.WriteLine("Этот день недели рабочий");
}
else if (number == 6 || number == 7)
{
    System.Console.WriteLine("Этот день недели выходной");
}
else
{
    System.Console.WriteLine("Такого дня недели нет");
}
