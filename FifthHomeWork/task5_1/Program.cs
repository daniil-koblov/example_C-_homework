// Первая задача. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int random = new Random().Next(100, 1000);
        a[i] = random;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
    int count = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] % 2 == 0) count++;
        else count+=0;
    }
    Console.WriteLine($"Кол-во четных чисел массива равно {count}");
}

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);