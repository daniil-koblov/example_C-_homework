// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();

int[,] FillSnakeArray(int m, int n)
{
    int[,] matr = new int[m, n];
    int num = 1;
    for (int delta = 0; delta < n / 2; delta++)
    {
        for (int i = 0 + delta; i <= m - m + delta; i++)
        {
            for (int j = 0 + delta; j < n - delta; j++)
            {
                matr[i, j] = num;
                num++;
            }
        }
        num--;
        for (int i = 0 + delta; i <= m - 1 - delta; i++)
        {
            for (int j = n - 1 - delta; j <= n - 1 - delta; j++)
            {
                matr[i, j] = num;
                num++;
            }
        }
        num--;
        for (int i = m - 1 - delta; i <= n - 1 - delta; i++)
        {
            for (int j = n - 1 - delta; j >= 0 + delta; j--)
            {
                matr[i, j] = num;
                num++;
            }
        }
        num--;
        if (delta == 0)
        {
            for (int i = m - 1; i > m - m; i--)
            {
                for (int j = 0; j <= n - n; j++)
                {
                    matr[i, j] = num;
                    num++;
                }
            }
        }
    }
    return matr;
}

void PrintSnakeArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write($"0" + matr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int a = new Random().Next(4, 5);
int b = new Random().Next(4, 5);

int[,] snakeArray = FillSnakeArray(a, b);
PrintSnakeArray(snakeArray);