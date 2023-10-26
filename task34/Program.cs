/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

int[] GenerateArray(int sizeArray, int leftRange; int rightRange)
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next();
    }
}





int [] array = GenerateArray(5, 100, 999)
PrintArray(array);
