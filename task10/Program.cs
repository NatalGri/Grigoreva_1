/* Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = (number % 100) / 10;
    Console.WriteLine($"Вторая цифра числа {number} это {result}");
}
else
{
    System.Console.WriteLine("Ошибка! Число должно быть трехзначным!");
}

/* string? strNumber = Console.ReadLine(); // короткое решение с помощью массива букв
                                           // (поэтому оформлен без [] - так был бы массив строк)
if (strNumber?.Length == 3)
System.Console.WriteLine(strNumber[1]);
else
System.Console.WriteLine("Введено не трехзначное число! "); */