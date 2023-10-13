/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
    return distAB;
}

Console.Write("Input X coordinat of A: "); 
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinat of A: "); 
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinat of A: "); 
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinat of B: "); 
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinat of B: "); 
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinat of B: "); 
int zBcoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"Distance between A & B is {distanceAB:f2}"); 
