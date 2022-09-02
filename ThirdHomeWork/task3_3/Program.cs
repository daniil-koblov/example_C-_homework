// Третья задача. Программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= num)
{
    Console.Write($"{count*count*count} ");
    count++;
}
Console.WriteLine();