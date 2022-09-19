// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();

int[,,] FillArray(int m, int n, int k)
{
    int[,,] arr = new int[m, n, k];
    int[] arr2 = new int[m * n * k];

    Console.WriteLine($"Создаем и выводим одномерный массив с уникальными числами.");
    for (int i = 0; i < arr2.Length; i++)
    {
        arr2[i] = new Random().Next(10, 100);
    }
    int maxNumber = arr2[0];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] > maxNumber) maxNumber = arr2[i];
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        for(int j = i + 1; j < arr2.Length; j++)
        {
            if(arr2[i] == arr2[j])
            {
                maxNumber++;
                arr2[j] = maxNumber;
            }
        }
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
    Console.WriteLine();

    Console.WriteLine($"Записываем эти уникальные числа в трехмерный массив.");
    int h = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int v = 0; v < arr.GetLength(2); v++)
            {
                arr[i, j, v] = arr2[h];
                h++;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    Console.WriteLine($"Выводим трехмерный массив с уникальными числами.");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int v = 0; v < arr.GetLength(2); v++)
            {
                Console.Write($"{arr[i, j, v]}{(i, j, v)} ");
            }
            Console.WriteLine();
        }
    }
}

int a = 2;
int b = 2;
int c = 2;

Console.WriteLine($"Первый массив.");
int[,,] matrix1 = FillArray(a, b, c);
PrintArray(matrix1);