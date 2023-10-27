/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9   ->   (-0,5; -0,5) */


double[] Point (int[] newArray)
{
    double[] arrayPoint = new double[2];
    
    arrayPoint[0] = Math.Round(((double)(newArray[3] - newArray[1]) / (newArray[0] - newArray[2])), 1);
    arrayPoint[1] = Math.Round(((double)newArray[0] * arrayPoint[0] + newArray[1]), 1);
    
    return arrayPoint;   
}


System.Console.Write("Введите значения k1, b1 и k2, b2 по порядку: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);

if(array[0] != array[2])
    System.Console.WriteLine("Точка пересечения двух прямых: " + "(" + string.Join("; ", Point(array)) + ")");
else
    System.Console.WriteLine("Значения коэффициентов k не могут быть равны");

