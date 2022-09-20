// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

int FindSum(int b, int a)
{
    int len = a - (b - 1);
    int result = 0;
    for (int i = 0; i < len; i++)
    {
        result += b;
        b++;
    }
    return result;
}

Console.WriteLine("Задачайте промежуток из двух чисел.");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (n > m)
{
    int num = FindSum(m, n);
    Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {num}");
}
else Console.WriteLine("Первое число должно быть меньше второго.");