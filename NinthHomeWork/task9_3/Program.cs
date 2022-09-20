// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
Console.Clear();

Console.WriteLine("Программа считает 2 положительных числа по функции Аккермана.");
Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // a
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine()); // b
if (m > 0 && n > 0)
{
    Console.WriteLine($"Результат вычислений A({m},{n}) получился в виде {Ackermann(m, n)}.");
    int Ackermann(int a, int b)
    {
        if (a == 0)
        {
            return b + 1;
        }
        else if ((a > 0) && (b == 0))
        {
            return Ackermann(a - 1, 1);
        }
        else if ((a > 0) && (b > 0))
        {
            return Ackermann(a - 1, Ackermann(a, b - 1));
        }
        return b + 1;
    }
}
else Console.WriteLine("Введенные числа должны быть больше нуля.");