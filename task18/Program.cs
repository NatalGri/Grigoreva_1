/* Задача 18: Напишите программу, которая по заданному номеру четверти, показывает
диапазон возможных координат точек в этой четверти (x и y).*/

System.Console.Write("Введите номер четверти от 1 до 4: ");
int chet = Convert.ToInt32(Console.ReadLine());

string [] arrayMsg = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0", "Ошибка! \nТакой четверти нет."};

if (chet == 1)
{
    System.Console.WriteLine(arrayMsg[0]);
}
else if (chet == 2)
{
    System.Console.WriteLine(arrayMsg[1]);
}
else if (chet == 3)
{
    System.Console.WriteLine(arrayMsg[2]);
}
else if (chet == 4)
{
    System.Console.WriteLine(arrayMsg[3]);
}
else
{
    System.Console.WriteLine(arrayMsg[4]);
}


/* Console.WriteLine("Введите номер четверти от 1 до 4"); // второй способ
int chet = Convert.ToInt32(Console.ReadLine());
string[] arrayMsg = { "x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0", "Ошибка!" };

switch (chet) // switch - case - используется, когда мы ожидаем конкретное значение, а не диапазон
{
    case 1:
        System.Console.WriteLine(arrayMsg[0]);
        break;
    case 2:
        System.Console.WriteLine(arrayMsg[1]);
        break;
    case 3:
        System.Console.WriteLine(arrayMsg[2]);
        break;
    case 4:
        System.Console.WriteLine(arrayMsg[3]);
        break;
    default:
        System.Console.WriteLine(arrayMsg[4]);
        break;
}  */


/* Console.WriteLine("Введите номер четверти от 1 до 4"); // третий способ
int chet = Convert.ToInt32(Console.ReadLine()); 
string[] arraystr = { "x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0", "Ошибка!" };

if (chet > 0 && chet < 5)
{
System.Console.WriteLine(arraystr[chet - 1]);
}
else
{
System.Console.WriteLine(arraystr[4]);
} */