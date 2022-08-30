// Вторая задача на вывод третьей цифры, введенного числа.


Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num1);
if (str.Length > 2)
{
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("В введенном числе нет третьей цифры");
}