/* Задача 19: Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int num_1 = number / 10000;
    int num_2 = (number / 1000) % 10;
    int num_4 = (number % 100) / 10;
    int num_5 = number % 10;

    if (num_1 == num_5 && num_2 == num_4)
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}    
else
{
    System.Console.WriteLine("Введенное не пятизначное число");
}  

