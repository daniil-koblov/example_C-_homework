// Первая задача на вывод второй цифры, введенного трехзначного числа.
// Второй вариант, в котором случайное число.
Console.Clear();

int num1 = new Random().Next(100, 1000);
Console.WriteLine(num1);
int num2 = num1 / 10;
int num3 = num2 % 10;

Console.WriteLine($"{num3}");