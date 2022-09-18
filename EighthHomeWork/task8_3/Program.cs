// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();

int[,] FillMatrix(int m, int n)
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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] PrintResultMultMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = 0;
            for (int v = 0; v < matr.GetLength(1); v++) matr[i, j] += matr1[i, v] * matr2[v, j];
        }
    }
    return matr;
}

int a = new Random().Next(2, 3);
int b = new Random().Next(2, 3);

Console.WriteLine($"Первая матрица.");
int[,] matrix1 = FillMatrix(a, b);
PrintMatrix(matrix1);

Console.WriteLine();

Console.WriteLine($"Вторая матрица.");
int[,] matrix2 = FillMatrix(a, b);
PrintMatrix(matrix2);

Console.WriteLine();

Console.WriteLine($"Результат перемножения двух матриц.");
PrintMatrix(PrintResultMultMatrix(matrix1, matrix2));