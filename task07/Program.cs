/* Задача 7. Напишите программу, которая принимает на вход трехзначное число
и на выходе показывает последнюю цифру этого числа.
Например:
456 -> 6
782 -> 2 */

Console.Write("Введите трехзначное число: "); 
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int last_num = number % 10;
    System.Console.WriteLine($"Последняя цифра числа {number} -> {last_num}");
}
else
{
    System.Console.WriteLine($"Введено не трехзначное число");    
}

