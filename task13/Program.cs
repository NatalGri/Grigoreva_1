/* Задача 13. Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
326791123 -> 6
 */

 System.Console.WriteLine("Введите целое число: ");
 int number = Convert.ToInt32(Console.ReadLine());

int num = number;

 while (num >= 1000)
 {
    num = num / 10;
 }

 if (num > 99 && num < 1000)
 {
    int res = num % 10;
    System.Console.WriteLine($"Третья цифра числа {number} это {res}");
 } 
 else
 {
    System.Console.WriteLine($"Третьей цифры в числе {number} нет");
 }