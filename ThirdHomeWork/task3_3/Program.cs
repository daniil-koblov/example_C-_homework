// Третья задача. Программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

void Cubes(int a)
{
    int count = 1;

    while(count <= a)
    {
        Console.Write($"{count*count*count} ");
        count++;
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Cubes(num);