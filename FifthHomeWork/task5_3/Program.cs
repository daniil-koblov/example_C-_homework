// Третья задача. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int random = new Random().Next(1, 100);
        a[i] = random;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
    int min = a[0];
    int max = a[0];
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] < min) min = a[i];
        else if(a[i] > max) max = a[i];
    }
    Console.WriteLine($"Разница между минимальным и максимальным числом равна {max - min}");
}

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);
