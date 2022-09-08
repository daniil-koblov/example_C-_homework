// Вторая задача. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int random = new Random().Next(-10, 10);
        a[i] = random;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
    int sum = 0;
    for(int i = 1; i < a.Length; i += 2) sum += a[i];
    Console.WriteLine($"Сумма элементов нечентных позиций равна {sum}");
}

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);