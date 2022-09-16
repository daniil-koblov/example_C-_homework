// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

int[,] arr(int x, int y)
{
    int m = new Random().Next(0, 10);
    int n = new Random().Next(0, 10);
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(x, y + 1);
        }
    }
    return array;
}
void PrintArrayInt(int[,] arrayInt)
{
    for (int i = 0; i < arrayInt.GetLength(0); i++)
    {
        for (int j = 0; j < arrayInt.GetLength(1); j++)
        {
            if (j != (arrayInt.GetLength(1) - 1))
            {
                Console.Write($"{arrayInt[i, j]}, ");
            }
            else
            {
                Console.Write($"{arrayInt[i, j]}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[] Average(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        average[i] = Math.Round((sum / array.GetLength(0)), 2);
    }
    return average;
}

int[,] array = arr(0, 9);
double[] average = Average(array);

PrintArrayInt(array);
Console.WriteLine(string.Join("; ", average));

