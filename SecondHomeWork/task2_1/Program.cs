// Первая задача на вывод второй цифры, введенного трехзначного числа.
Console.Clear();

Console.WriteLine("Введите трехзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1 / 10;
int num3 = num2 % 10;

Console.WriteLine($"{num3}");