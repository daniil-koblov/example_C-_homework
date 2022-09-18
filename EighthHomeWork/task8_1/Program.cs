// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();

int m = new Random().Next(3, 4);
int n = new Random().Next(3, 5);
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < num.GetLength(0); i++)
{
    int[] array = new int[n];
    for (int j = 0; j < num.GetLength(1); j++)
    {
        array[j] = num[i,j];
    }
    Array.Sort(array);
    Array.Reverse(array);
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i,j] = array[j];
    }
}
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}