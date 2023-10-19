/* Задача 20: Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

int[] A = new int[2];
System.Console.Write("Введите координату Х точки А: ");
A[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки А: ");
A[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

int[] B = new int[2];
System.Console.Write("Введите координату Х точки B: ");
B[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки B: ");
B[1] = Convert.ToInt32(Console.ReadLine());

int resX = (int) Math.Pow(A[0] - B[0], 2);
// int resX = Convert.ToInt32(Math.Pow(A[0] - B[0], 2));

int resY = (int) Math.Pow(A[1] - B[1], 2);

double distance = Math.Sqrt(resX + resY);

System.Console.WriteLine(Math.Round(distance, 2));

// Math.Pow(value1, value2) -- возведение value1 в степень value2
// Math.Round(value1, value2) -- округляет value1 до value2 знаков после запятой
//Math.Sqrt() -> взятие квадратного корня