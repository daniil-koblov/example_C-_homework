// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
Console.WriteLine($"Создаем массив.");
int m = new Random().Next(4, 5);
int n = new Random().Next(4, 5);
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
Console.WriteLine($"Выводим суммы каждой строки массива.");
int[] sumArray = new int[m];
for (int i = 0; i < num.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum += num[i, j];
    }
    sumArray[i] = sum;
    Console.Write($"{sumArray[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Ответ:");
int minI = 1;
int min = sumArray[0];
for (int i = 0; i < num.GetLength(0); i++)
{
    if(sumArray[i] < min) minI++;
}
Console.WriteLine($"На {minI} строке наименьшая сумма элементов.");