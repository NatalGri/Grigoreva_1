/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Fib(int N)
{
    Console.Write("0 1 ");
    int num1 = 0;
    int num2 = 1;

    for (int i = 0; i < N - 2; i++)
    {
        int res = num1 + num2;
        Console.Write(res + " ");
        num1 = num2;
        num2 = res;
    }    
}


Fib(ReadInt("Введите количество цифр: "));

