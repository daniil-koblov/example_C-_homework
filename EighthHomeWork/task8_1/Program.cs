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

int[,] FillUnordered(int m, int n)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

int[,] Ordering(int[,] num, int v)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        int[] array = new int[v];
        for (int j = 0; j < num.GetLength(1); j++)
        {
            array[j] = num[i, j];
        }
        Array.Sort(array);
        Array.Reverse(array);
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = array[j];
        }
    }
    return num;
}

void PrintArray(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write($"{num[i, j]} ");
        }
        Console.WriteLine();
    }
}

int a = new Random().Next(3, 4);
int b = new Random().Next(4, 5);
Console.WriteLine($"Неупорядоченный массив.");
int[,] num1 = FillUnordered(a, b);
PrintArray(num1);
Console.WriteLine($"Упорядоченный массив.");
Ordering(num1, b);
PrintArray(num1);
