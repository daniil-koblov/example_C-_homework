// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.Clear();

Console.Write("На какой позиции надо найти элемент? ");
Console.WriteLine();
int position1 = Convert.ToInt32(Console.ReadLine());
int position2 = Convert.ToInt32(Console.ReadLine());
int m = new Random().Next(0, 8);
int n = new Random().Next(0, 8);
int[,] num = new int [m,n];
for(int i = 0; i < num.GetLength(0); i++)
{
    for(int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
if ((position1 < num.GetLength(0)) && (position2 < num.GetLength(1))) Console.WriteLine(num[position1, position2]);
else Console.WriteLine("Такого элемента нет");