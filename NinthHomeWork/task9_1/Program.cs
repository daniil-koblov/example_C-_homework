// // Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8"". Изначально в условии было "4, 6, 7, 8". Думаю, что это опечатка.

// P.S. Вспомнил про точное уточнение ТЗ. Сам в тех. поддержке в Yclients работаю, поэтому на своем 
// опыте знаю, что плохое ТЗ - результат ХЗ) У меня премия ниже за такие дела. 
// Извиняюсь за отсутпление.

Console.Clear();

int[] FillArray(int b, int a)
{
    int[] array = new int[a - (b - 1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = b;
        b++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

Console.WriteLine("Задачайте промежуток из двух чисел.");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (n > m)
{
    Console.WriteLine($"Натуральные числа от {m} до {n}");
    int[] num = FillArray(m, n);
    PrintArray(num);
}
else Console.WriteLine("Первое число должно быть меньше второго.");