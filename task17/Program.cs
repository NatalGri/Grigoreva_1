/* 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта точка.*/

System.Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в первой четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится во второй четверти");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в третьей четверти");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка лежит в четвертной четверти");
}
else
{
    System.Console.WriteLine("Ошибка! \nОдна из координат равна нулю");
}


// решение задачи с помощью массива

/* int[] coord = new int[2];

string[] msg = { "Точка находится в первой четверти", "Точка находится во второй четверти", "Точка находится в третьей четверти", "Точка лежит в четвертной четверти", "Ошибка! \nОдна из координат равна нулю" };

System.Console.Write("Введите координату Х: ");
coord[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y: ");
coord[1] = Convert.ToInt32(Console.ReadLine());

if (coord[0] > 0 && coord[1] > 0)
{
    System.Console.WriteLine(msg[0]);
}
else if (coord[0] < 0 && coord[1] > 0)
{
    System.Console.WriteLine(msg[1]);
}
else if (coord[0] < 0 && coord[1] < 0)
{
    System.Console.WriteLine(msg[2]);
}
else if (coord[0] > 0 && coord[1] < 0)
{
    System.Console.WriteLine(msg[3]);
}
else
{
    System.Console.WriteLine(msg[4]);
} */