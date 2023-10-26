// приводит массив строк, введенный через разделитель (благодаря .Split), к массиву целых чисел (благодаря int.Parse)
// .Split() - в таком написании по умолчанию разделитель - пробел (то есть если числа ввели через пробел: 2 5 10 3); 
// записав, например так: .Split(", ") - числа должны быть изначально введены через точку с пробелом: 2, 5, 10, 3 
// ! - нужен для того, чтобы не запускался метод Split, если вернется пустая строка

// int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// System.Console.WriteLine(string.Join(" | ", array));


/* Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.
(Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон). */


bool CheckTriangle(int[] arr)
{
    if (arr[0] < arr[1] + arr[2] && arr[1] < arr[0] + arr[2] && arr[2] < arr[0] + arr[1])
    {
        return true;
    }
    return false;
}


System.Console.Write("Введите значения сторон: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

if (array.Length != 3)
{
    System.Console.Write("Введено не три стороны");
    return;
}

System.Console.WriteLine(CheckTriangle(array));