// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Например:
// 3 -> среда
// 5 -> пятница

/* Console.Write("Введите число от 1 до 7: "); один вариант решения
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (num == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (num == 3)
{
    System.Console.WriteLine("Среда");
}
else if (num == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (num == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (num == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (num == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
    System.Console.WriteLine("Ошибка");
}
 */


Console.Write("Введите номер дня недели: "); // второй вариант решения
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1: 
    {
        System.Console.WriteLine("Понедельник");
        break;
    }
    case 2: 
    {
        System.Console.WriteLine("Вторник");
        break;
    }
    case 3: 
    {
        System.Console.WriteLine("Среда");
        break;
    }
    case 4: 
    {
        System.Console.WriteLine("Четверг");
        break;
    }
    case 5: 
    {
        System.Console.WriteLine("Пятница");
        break;
    }
    case 6: 
    {
        System.Console.WriteLine("Суббота");
        break;
    }
    case 7: 
    {
        System.Console.WriteLine("Воскресенье");
        break;
    }
    default:
    {
        System.Console.WriteLine("Такого дня недели не существует!");
        break;
    }
}


